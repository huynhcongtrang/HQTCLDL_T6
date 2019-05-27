
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

namespace CDStoreManagement.Utils.PayProductOfTransaction
{

    public partial class PayProduct : Form
    {
        private double expired = 0 ;
        private int idTransac;
        private string dateTran = "";
    
        bool checkExceedDateHire = false;
        public static List<ItemReview> listItemReview = new List<ItemReview>();
        public PayProduct()
        {
            InitializeComponent();
        }

        #region method 
        int GetPercentDiscountEvent()
        {
            List<Event> eve = EventControler.Instance.GetListEventByDate(dateTran);
            if (!eve.Any())
            {
                return 0;
            }
            int percenDiscount = 0;
            foreach (Event e in eve)
            {
                percenDiscount += e.PercentDiscount;
            }
            return percenDiscount;
        }
        void LoadPrice()
        {
            int percentDiscountEvent = GetPercentDiscountEvent();
            Hire hire = HireControler.Instance.GetHireByIdTransa(idTransac);
            Rule_hire ruleHire = RuleHireControler.Instance.GetRuleHire(Common1.idRuleHire);
            double totalHireReal = hire.Total - hire.Deposit + hire.Discount;
            double totalFine = 0;
            foreach (ItemReview item in listItemReview)
            {
                if (item.TotalDamage > 0)
                {
                    totalFine += item.TotalDamage * item.Price;
                }
            }
            double priceDiscountEvent = 0;
            if (percentDiscountEvent != 0)
            {
                priceDiscountEvent = (totalFine* ruleHire.Percent_hire/100) * percentDiscountEvent / 100;
            }
            if (checkExceedDateHire)
            {
                expired = totalHireReal * ruleHire.Percent_fine / 100;
                totalFine += totalHireReal * ruleHire.Percent_fine / 100;
            }
           
            lbPriceHire.Text = totalHireReal.ToString("N");
            lbPriceDiscount.Text = (hire.Discount- priceDiscountEvent).ToString("N");
            lbPriceDepositAndReal.Text = hire.Deposit.ToString("N");
            lbPriceFine.Text = totalFine.ToString("N");
            if ((hire.Deposit - totalFine) > 0)
            {
                lbTotalPrice.Text = (hire.Deposit - totalFine - priceDiscountEvent).ToString("N");
            }
            else
            {
                lbTotalPrice.Text = (totalHireReal - priceDiscountEvent).ToString("N");
            }
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

        void LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã", typeof(int));
            dt.Columns.Add("Tên sản phẩm", typeof(string));
            dt.Columns.Add("Giá", typeof(string));
            dt.Columns.Add("Số lượng", typeof(string));
            dt.Columns.Add("Hư hỏng", typeof(string));

            foreach (ItemReview item1 in listItemReview)
            {
                Product pro = ProductControler.Instance.GetProductById(item1.IdProduct);
                dt.Rows.Add(item1.IdProduct, pro.Name, (pro.Price - pro.Discount).ToString("N"), item1.TotalProduct, item1.TotalDamage);
            }

            dtgvProduct.ForeColor = Color.Black;
            dtgvProduct.DataSource = dt;
        }

        public void ShowDetailTransaction(int idTran)
        {
            idTransac = idTran;
            Transaction tran = TransactionControler.Instance.GetTransactionById(idTran);
            dateTran = String.Format("{0:yyyy-MM-dd HH:mm:ss}", tran.Created); ;

            // check ngay tra
            DateTime today = DateTime.Today;
            int totalDatePay = (int)(today - tran.Created).TotalDays;
            Rule_hire ruleHire = RuleHireControler.Instance.GetRuleHire(Common1.idRuleHire);
            if (totalDatePay > ruleHire.Number_date_pay)
            {
                checkExceedDateHire = true;
                lbAnoHire.Text = "Bạn đã trả quá hạng (Ngày trả : " + String.Format("{0:dd-MM-yyyy}", tran.Created.AddDays(ruleHire.Number_date_pay)) + ")";
            }
            else lbAnoHire.Text = "Không";


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
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã", typeof(int));
            dt.Columns.Add("Tên sản phẩm", typeof(string));
            dt.Columns.Add("Giá", typeof(string));
            dt.Columns.Add("Số lượng", typeof(string));
            dt.Columns.Add("Hư hỏng", typeof(string));

            foreach (TransactionaDetail tranDe in listTranDe)
            {
                Product pro = ProductControler.Instance.GetProductById(tranDe.Id_product);
                dt.Rows.Add(tranDe.Id_product, pro.Name, tranDe.Price.ToString("N"), tranDe.Total_product, "0");
                ItemReview item = new ItemReview(tranDe.Id_product, tranDe.Total_product, 0,tranDe.Price);
                listItemReview.Add(item);
            }

            dtgvProduct.ForeColor = Color.Black;
            dtgvProduct.DataSource = dt;

            // load so tien
            LoadPrice();

        }
        #endregion


        #region event


        
        private void btnCLose_Click(object sender, EventArgs e)
        {
            listItemReview.Clear();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = SelectProduct();
            if (id != 0)
            {
                using (InputDamage inputDamage = new InputDamage())
                {
                    inputDamage.ShowDetailProduct(id);
                    inputDamage.ShowDialog();
                }
                LoadData();
                LoadPrice();
            }
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            double totalPrice = 0;
            double deposit = Convert.ToDouble(lbPriceDepositAndReal.Text);
            double discount = Convert.ToDouble(lbPriceDiscount.Text);
            double damage = Convert.ToDouble(lbPriceFine.Text);
            double hire = Convert.ToDouble(lbPriceHire.Text);
            if (deposit == damage)
            {
                totalPrice = damage;
            }
            else
            {
                totalPrice = hire - discount;
            }
            HireControler.Instance.UpdateHire(idTransac, damage, expired, totalPrice);
            foreach (ItemReview item in listItemReview)
            {
                Product pro = ProductControler.Instance.GetProductById(item.IdProduct);
                int total = pro.TotalHire - item.TotalProduct;
                int totalMain = pro.Total - item.TotalDamage;
                ProductControler.Instance.UpdateProduct(2, item.IdProduct, total);
                ProductControler.Instance.UpdateProduct(item.IdProduct, totalMain);
            }
            TransactionControler.Instance.UpdateTypeByIdTran(idTransac, 3);
            listItemReview.Clear();
            MessageBox.Show("Thành công !");
            this.Close();
        }
        #endregion
    }

}
