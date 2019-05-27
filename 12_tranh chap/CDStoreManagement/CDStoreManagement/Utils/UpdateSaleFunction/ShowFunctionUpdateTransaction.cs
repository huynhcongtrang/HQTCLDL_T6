using CDStoreManagement.Common;
using CDStoreManagement.Controllers;
using CDStoreManagement.Models;
using CDStoreManagement.Utils.SalesFunction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDStoreManagement.Utils.UpdateSaleFunction
{
    public partial class ShowFunctionUpdateTransaction : Form
    {
        int idTransac = 0;
        private List<Item> listTeampItem = new List<Item>();
        public ShowFunctionUpdateTransaction()
        {
            InitializeComponent();
        }
        #region method

        public int SelectProduct()
        {
            int id = 0;
            if (dtgvListProduct.SelectedRows.Count > 0)
            {
                try
                {
                    id = Convert.ToInt16(dtgvListProduct.SelectedRows[0].Cells["Mã"].Value.ToString());
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
        int LoadEvent()
        {
            //load Event
            int discountEvent = 0;
            List<Event> eve = EventControler.Instance.GetListEventByDate();
            lbAnnount.Text = "Không";
            if (eve.Any())
            {
                lbAnnount.Text = "";
                foreach (Event ev in eve)
                {
                    lbAnnount.Text += " + Sự kiện  " + ev.Title + "   - Giảm " + ev.PercentDiscount + "%  ";
                    discountEvent += ev.PercentDiscount;
                }
            }
            return discountEvent;
        }
        void LoadHire()
        {
            // phan tram giam gia . load lai thong bao
            int discountEvent = LoadEvent();
            // price hire
            ptbIconPriceHire.Visible = true;
            lbTitleHire.Visible = true;
            lbPriceHire.Visible = true;
            lbUnitHire.Visible = true;
            //price deposit
            lbTittleDepositAndReal.Text = "Số tiền cọc :";
            double priceReal = 0;
            double priceHire = 0;
            double priceDeposit = 0;
            double priceDiscount = 0;
            double priceTotal = 0;
            double countProduct = 0; // đếm số lượng đĩa

            foreach (Item item in Common1.cart)
            {
                Product pro = ProductControler.Instance.GetProductById(item.IdProduct);
                priceReal += (pro.Price - pro.Discount) * item.TotalProduct;
                countProduct += item.TotalProduct;
            }

            if (priceReal != 0)
            {
                Rule_hire rule_hire = RuleHireControler.Instance.GetRuleHire(Common1.idRuleHire);
                priceHire = priceReal * rule_hire.Percent_hire / 100;
                priceDeposit = priceReal * rule_hire.Percent_deposit / 100;
                if (discountEvent != 0)
                {
                    priceDiscount = priceHire * discountEvent / 100;
                }
                if (countProduct >= rule_hire.Total_discount)
                {
                    priceDiscount += priceHire * rule_hire.Percent_discount / 100;
                }
                priceTotal = priceHire + priceDeposit - priceDiscount;
            }
            lbPriceHire.Text = priceHire.ToString("N2");
            lbPriceDepositAndReal.Text = priceDeposit.ToString("N2");
            lbPriceDiscount.Text = priceDiscount.ToString("N2");
            lbTotalPrice.Text = priceTotal.ToString("N2");

        }
        void LoadBuy()
        {
            // phan tram giam gia . load lai thong bao
            int discountEvent = LoadEvent();
            // price hire
            ptbIconPriceHire.Visible = false;
            lbTitleHire.Visible = false;
            lbPriceHire.Visible = false;
            lbUnitHire.Visible = false;
            //price deposit
            lbTittleDepositAndReal.Text = "Số tiền thực :";
            double priceDiscount = 0;
            double priceReal = 0;
            double priceTotal = 0;
            int countProduct = 0;// đếm số sản phẩm trong giỏ
            foreach (Item item in Common1.cart)
            {
                Product pro = ProductControler.Instance.GetProductById(item.IdProduct);
                priceReal += (pro.Price - pro.Discount) * item.TotalProduct;
                countProduct += item.TotalProduct;
            }
            if (priceReal != 0)
            {
                Rule_buy ruleBuy = RuleBuyControler.Instance.GetRuleBuy(Common1.idRuleBuy);
                if (discountEvent != 0)
                {
                    priceDiscount = priceReal * discountEvent / 100;
                }
                if (countProduct >= ruleBuy.Total_discount)
                {
                    priceDiscount += priceReal * ruleBuy.Percent_discount / 100;
                }
                priceTotal = priceReal - priceDiscount;
            }
            // show
            lbPriceDepositAndReal.Text = priceReal.ToString("N2");
            lbPriceDiscount.Text = priceDiscount.ToString("N2");
            lbTotalPrice.Text = priceTotal.ToString("N2");

        }
        void LoadProductSelected()
        {

            if (Common1.cart != null)
            {

                DataTable dt = new DataTable();
                dt.Columns.Add("Mã", typeof(int));
                dt.Columns.Add("Tên đĩa", typeof(string));
                dt.Columns.Add("Giá", typeof(string));
                dt.Columns.Add("Số Lượng", typeof(int));
                foreach (Item item in Common1.cart)
                {
                    Product pro = ProductControler.Instance.GetProductById(item.IdProduct);
                    dt.Rows.Add(pro.Id, pro.Name, (pro.Price - pro.Discount).ToString("N"), item.TotalProduct);
                }
                dtgvSelected.ForeColor = Color.Black;
                dtgvSelected.DataSource = dt;
            }
        }
        bool CheckExitProduct(int total, int totalTemp, int totalHire, int totalBuy)
        {
            int result = total + totalTemp - totalHire - totalBuy;
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        void LoadListProductFiel(List<Product> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã", typeof(int));
            dt.Columns.Add("Tên đĩa", typeof(string));
            dt.Columns.Add("Giá", typeof(string));
            dt.Columns.Add("Trạng thái", typeof(string));
            foreach (Product item in list)
            {
                string exitProduct = CheckExitProduct(item.Total, GetTotalItem(item.Id), item.TotalHire, item.TotalBuy) ? "Còn hàng" : "Hết hàng";
                dt.Rows.Add(item.Id, item.Name, (item.Price - item.Discount).ToString("N"), exitProduct);
            }

            dtgvListProduct.ForeColor = Color.Black;
            dtgvListProduct.DataSource = dt;
        }
        void LoadListProduct()
        {
            List<Product> list = ProductControler.Instance.GetListProduct();
            LoadListProductFiel(list);

        }
        // tra ve so luong san pham con lai
        int GetTotalAndCheckExitsInCart(int idPro) {
            foreach (Item item in Common1.cart) {
                if (item.IdProduct == idPro) {
                    return item.TotalProduct;
                }
            }
            return 0;
        }
        int GetTotalByListTeampItem(int idPro) {
            foreach (Item item in listTeampItem)
            {
                if (item.IdProduct == idPro)
                {
                    return item.TotalProduct;
                }
            }
            return 0;
        }
        int GetTotalItem(int idPro) {
            if (GetTotalAndCheckExitsInCart(idPro) == 0)
            {
                return GetTotalByListTeampItem(idPro);
            }
            int totalCart = GetTotalAndCheckExitsInCart(idPro);
            int totalListTeam = GetTotalByListTeampItem(idPro);
            if (totalCart < totalListTeam)
            {
                return totalListTeam - totalCart;
            }
            return 0;
        }
        public void ShowDetailTransaction(int idTran)
        {
            idTransac = idTran;
            Transaction tran = TransactionControler.Instance.GetTransactionById(idTran);
            Customer cus = CustomerController.Instance.GetCustomerById(tran.Id_customer);

            // hien thi hinh thuc

            if (tran.Type == 1)
            {
                rbtBuy.Checked = true;
                rbtHire.Checked = false;
            }
            else {
                rbtBuy.Checked = false;
                rbtHire.Checked = true;
            }
            // hien thi thong tin cua customer
            txtPhone.Text = cus.Phone;
            txtNameCus.Text = cus.Name;
            txtAddress.Text = cus.Address;
            txtPhone.Enabled = false;
            txtNameCus.Enabled = false;
            txtAddress.Enabled = false;


            //load danh sách  sản phẩm 
            LoadListProduct();
            Common1.cart.Clear();
            listTeampItem.Clear();
            // load danh sach san pham chon roi
            List<TransactionaDetail> listTranDe = TransactionDetailControler.Instance.GetListTransactionDetailById(idTran);
            foreach (TransactionaDetail tranDe in listTranDe) {
                Item item = new Item(tranDe.Id_product, tranDe.Total_product);
                Common1.cart.Add(item);
                listTeampItem.Add(item);
            }
            LoadProductSelected();

            // so tien
            if (tran.Type == 1)
            {
                LoadBuy();
            }
            else
            {
                LoadHire();
            }


        }

        public int SelectedProduct()
        {
            int id = 0;
            if (dtgvSelected.SelectedRows.Count > 0)
            {
                try
                {
                    id = Convert.ToInt16(dtgvSelected.SelectedRows[0].Cells["Mã"].Value.ToString());
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
        #endregion

        #region event
        private void btnCLose_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Bạn thực sự muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                listTeampItem.Clear();
                Common1.cart.Clear();
                this.Close();
            }
        }


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            int id = SelectProduct();
            if (id != 0)
            {
                Product pro = ProductControler.Instance.GetProductById(id);
                if (pro.Total - pro.TotalHire - pro.TotalBuy + GetTotalItem(pro.Id) == 0) {
                    MessageBox.Show("Sản phẩm hết hàng !");
                    return;
                }
                using (ShowInputTotal2 continueSale = new ShowInputTotal2())
                {
                    continueSale.ShowDetailProduct(id, idTransac);
                    continueSale.ShowDialog();
                }
            }
            LoadProductSelected();
            LoadListProduct();
            if (rbtBuy.Checked)
            {
                LoadBuy();
            }
            else LoadHire();
        }

        private void rbtBuy_CheckedChanged(object sender, EventArgs e)
        {
            LoadBuy();
        }

        private void rbtHire_CheckedChanged(object sender, EventArgs e)
        {
            LoadHire();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = tbKeyWord.Text;
            if (keyword.Equals("") || keyword.Equals("Tìm kiếm . . .")) return;
            string extend = " where name like N'%" + keyword + "%'";
            List<Product> list = ProductControler.Instance.GetListProductByFillExtend(extend);
            LoadListProductFiel(list);
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            tbKeyWord.Text = "Tìm kiếm . . .";
            LoadListProduct();

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Common1.cart.Clear();
            LoadProductSelected();
            LoadListProduct();
        }

        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = SelectedProduct();
            if (id != 0)
            {
                using (EditTotalInput2 edit = new EditTotalInput2())
                {
                    edit.ShowDetailProduct(id,idTransac);
                    edit.ShowDialog();
                }
            }
            LoadProductSelected();
            LoadListProduct();
            if (rbtBuy.Checked)
            {
                LoadBuy();
            }
            else LoadHire();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = SelectedProduct();
            if (id != 0)
            {
                foreach (Item item in Common1.cart)
                {
                    if (id == item.IdProduct)
                    {
                        Common1.cart.Remove(item);
                        LoadProductSelected();
                        LoadListProduct();
                        if (rbtBuy.Checked)
                        {
                            LoadBuy();
                        }
                        else LoadHire();
                        return;
                    }
                }
            }
        }

        private void btnRent_Click(object sender, EventArgs e)
        {

            if (idTransac != 0)
            {
                Transaction tran = TransactionControler.Instance.GetTransactionById(idTransac);

                if (tran.Type == 3)
                {
                    MessageBox.Show("Không được sử dụng hoạt động này !");
                    return;
                }
                if (Common1.cart.Count == 0)
                {
                    MessageBox.Show("Bạn chưa chọn sản phẩm !");
                    return;
                }

                if (tran.Type == 1)
                {
                    BuyControler.Instance.DeleteBuy(idTransac);
                }
                else if (tran.Type == 2)
                {
                    HireControler.Instance.DeleteHire(idTransac);
                }
                List<TransactionaDetail> listTran = TransactionDetailControler.Instance.GetListTransactionDetailById(idTransac);
                foreach (TransactionaDetail tranDe in listTran)
                {
                    Product pro = ProductControler.Instance.GetProductById(tranDe.Id_product);
                    if (tran.Type == 1)
                    {
                        ProductControler.Instance.UpdateProduct(tran.Type, tranDe.Id_product, pro.TotalBuy - tranDe.Total_product);
                    }
                    else if (tran.Type == 2)
                    {
                        ProductControler.Instance.UpdateProduct(tran.Type, tranDe.Id_product, pro.TotalHire - tranDe.Total_product);
                    }
                }
                TransactionDetailControler.Instance.DeleteTransactionDetail(idTransac);

                int type = 0;
                if (rbtBuy.Checked)
                {
                    type = 1;
                }
                else if (rbtHire.Checked)
                {
                    type = 2;
                }

                TransactionControler.Instance.UpdateTypeByIdTran(idTransac, type);



                if (type == 1)
                {
                    //them san pham va so luong da mua // dong thoi cap nhat la thong tin san pham
                    foreach (Item item in Common1.cart)
                    {
                        Product pro = ProductControler.Instance.GetProductById(item.IdProduct);
                        ProductControler.Instance.UpdateProduct(type, item.IdProduct, item.TotalProduct + pro.TotalBuy);
                        TransactionDetailControler.Instance.InsertTransactionDetail(idTransac, item.IdProduct, item.TotalProduct, pro.Price - pro.Discount);

                    }
                    BuyControler.Instance.InsertBuy(idTransac, Convert.ToDouble(lbTotalPrice.Text), Convert.ToDouble(lbPriceDiscount.Text));
                }
                else if (type == 2)
                {
                    //them san pham va so luong da mua // dong thoi cap nhat la thong tin san pham

                    foreach (Item item in Common1.cart)
                    {
                        Product pro = ProductControler.Instance.GetProductById(item.IdProduct);
                        ProductControler.Instance.UpdateProduct(type, item.IdProduct, item.TotalProduct + pro.TotalHire);
                        TransactionDetailControler.Instance.InsertTransactionDetail(idTransac, item.IdProduct, item.TotalProduct, pro.Price - pro.Discount);

                    }
                    HireControler.Instance.InsertHire(idTransac, Convert.ToDouble(lbPriceDepositAndReal.Text), Convert.ToDouble(lbTotalPrice.Text), Convert.ToDouble(lbPriceDiscount.Text));
                }
                Common1.cart.Clear();
                if (MessageBox.Show("Thực hiện thành công ?", "Thông báo", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }

            }

        }

        #endregion


    }
}
