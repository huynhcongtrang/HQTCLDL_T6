using CDStoreManagement.Common;
using CDStoreManagement.Controllers;
using CDStoreManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDStoreManagement.Utils.SurveyChange
{
    public partial class FunctionSurveyChange : Form
    {
        private int idTranSac = 0;
        private string dateTran = "";
        public static List<ItemSurvey> listItemSurvey = new List<ItemSurvey>();
        public FunctionSurveyChange()
        {
            InitializeComponent();
        }






        #region method
        int GetPercentDiscountEvent() {
            List<Event> eve = EventControler.Instance.GetListEventByDate(dateTran);
            if (!eve.Any()) {
                return 0;
            }
            int percenDiscount = 0;
            foreach (Event e in eve) {
                percenDiscount += e.PercentDiscount;
            }
            return percenDiscount;
        }
        void LoadPrice()
        {
            Rule_buy ruleBuy = RuleBuyControler.Instance.GetRuleBuy(Common1.idRuleBuy);
            double totalPrice = 0;
            double totalPriceMain = 0;
            int totalChange = 0;
            int totalProduct = 0;
            foreach (ItemSurvey item in listItemSurvey) {
                totalPriceMain += item.Price * item.Total_Product;
                totalPrice += item.Price * item.Total_Change;
                totalChange += item.Total_Change;
                totalProduct += item.Total_Product;
            }
            if (totalChange == 0) {
                lbTotalPrice.Text = "0";
                return;
            }
            double totalPriceDiscount = 0;// cai nay luu so dia mua vuot qua giam gia ne
            double totalPriceDiscountEvent = totalPrice * GetPercentDiscountEvent() / 100;

            if ((totalProduct - totalChange) >= ruleBuy.Total_discount)
            {
                totalPriceDiscount = ruleBuy.Percent_discount * totalPrice / 100;
            }
            else {
                Buy buy = BuyControler.Instance.GetBuyByIdTransa(idTranSac);
                totalPriceDiscount = buy.Discount - (totalPriceMain * GetPercentDiscountEvent()/100);
            }
            lbTotalPrice.Text = (totalPrice - totalPriceDiscount - totalPriceDiscountEvent).ToString("N");
        }
        public int SelectProduct()
        {
            int id = 0;
            if (dtgvProduct.SelectedRows.Count > 0)
            {
                try
                {
                    id = Convert.ToInt16(dtgvProduct.SelectedRows[0].Cells["Mã"].Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn không chọn được cái này !");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm !");
            }
            return id;
        }
        void LoadProductInDataGirdView() {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã", typeof(int));
            dt.Columns.Add("Tên sản phẩm", typeof(string));
            dt.Columns.Add("Giá", typeof(string));
            dt.Columns.Add("Số lượng", typeof(string));
            dt.Columns.Add("Số lượng trả", typeof(string));
            foreach (ItemSurvey item in listItemSurvey) {
                Product pro = ProductControler.Instance.GetProductById(item.Id_Product);
                dt.Rows.Add(item.Id_Product, pro.Name, item.Price.ToString("N"), item.Total_Product, item.Total_Change);
            }
            dtgvProduct.ForeColor = Color.Black;
            dtgvProduct.DataSource = dt;

        }
        public void ShowDetailTransaction(int idTran) {
            idTranSac = idTran;
            Transaction tran = TransactionControler.Instance.GetTransactionById(idTran);
            lbDateCreated.Text = String.Format("{0:dd - MM - yyyy}", tran.Created);
            dateTran = String.Format("{0:yyyy-MM-dd HH:mm:ss}", tran.Created); ;
            // chỉ đọc
            txtPhone.Enabled = false;
            txtNameCus.Enabled = false;
            txtAddress.Enabled = false;
            // hien thi khách hang
            Customer cus = CustomerController.Instance.GetCustomerById(tran.Id_customer);
            txtPhone.Text = cus.Phone;
            txtNameCus.Text = cus.Name;
            txtAddress.Text = cus.Address;

            // load vao danh sach san pham
            List<TransactionaDetail> listTranDe = TransactionDetailControler.Instance.GetListTransactionDetailById(idTran);

            foreach (TransactionaDetail tranDe in listTranDe)
            {
                ItemSurvey item = new ItemSurvey(tranDe.Id_product, tranDe.Total_product, 0, tranDe.Price);
                listItemSurvey.Add(item);
            }
            LoadProductInDataGirdView();
            LoadPrice();


        }
        #endregion



        #region event

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int idPro = SelectProduct();
            if (idPro != 0)
            {

                using (InputChangeSurvey inputChange = new InputChangeSurvey())
                {
                    inputChange.ShowDetailProduct(idPro);
                    inputChange.ShowDialog();
                }
                LoadProductInDataGirdView();
                LoadPrice();

            }

        }
        private void btnCLose_Click(object sender, EventArgs e)
        {
            listItemSurvey.Clear();
            this.Close();
        }

        bool CheckSurvey() {
            if (rbtDamage.Checked == false && rbtNotContent.Checked == false && txReasonDifferent.Text.Equals("Nhập vào.....")) {
                return false;
            }
            return true;
        }
        private void btnRent_Click(object sender, EventArgs e)
        {
            if (!CheckSurvey()) {
                MessageBox.Show("Bạn chưa trả lời lý do !");
                return;
            }
            double priceChange =  Convert.ToDouble(lbTotalPrice.Text);//  soo tien tra lai
            if (priceChange > 0 ) {
                Buy buy = BuyControler.Instance.GetBuyByIdTransa(idTranSac);
                BuyControler.Instance.UpdateTotalBuyTran(idTranSac,buy.Total - priceChange);
                foreach (ItemSurvey item in listItemSurvey) {
                    TransactionDetailControler.Instance.UpdateTotalDetailTransaction(idTranSac , item.Id_Product , item.Total_Product - item.Total_Change);
                    Product pro = ProductControler.Instance.GetProductById(item.Id_Product);
                    ProductControler.Instance.UpdateTotalAndTotalHireProduct(item.Id_Product,pro.Total- item.Total_Change,pro.TotalBuy - item.Total_Change);
                }
            }

            listItemSurvey.Clear();
            MessageBox.Show("Thực hiện thành công !");
            this.Close();

        }
        #endregion


    }
}
