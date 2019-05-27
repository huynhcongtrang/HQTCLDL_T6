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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDStoreManagement.Utils.SalesFunction
{
    public partial class ShowFunctionRent : Form
    {
        public ShowFunctionRent()
        {
            InitializeComponent();
        }

        #region method

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
        int LoadEvent() {
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
                    priceDiscount = priceHire * discountEvent/ 100;
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
        bool CheckExitProduct(int total, int totalHire, int totalBuy)
        {
            int result = total - totalHire - totalBuy;
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
                string exitProduct = CheckExitProduct(item.Total, item.TotalHire, item.TotalBuy) ? "Còn hàng" : "Hết hàng";
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

        //kiem tra du lieu nhap khong co ki tu dat biet
        bool CheckValiInput(string value)
        {
            if (value.Equals("") || !Regex.IsMatch(value, @"^[\p{L}\p{M}' \.\-]+$"))
            {
                return false;
            }
            return true;
        }

        bool CheckVailInputEmty(string value)
        {
            if (value.Equals(""))
                return false;
            return true;
        }

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        //Kiem tra xem phone có đủ 10 số hay không
        public bool CheckPhone(string pText)
        {
            int number = 0;
            foreach (char chr in pText)
            {
                number += 1;
            }
            if (number == 10)
                return true;
            return false;
        }
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
        private void ShowFunctionRent_Load(object sender, EventArgs e)
        {
            LoadListProduct();
            LoadProductSelected();
            if (rbtBuy.Checked)
            {
                LoadBuy();
            }
            else LoadHire();
        }
        private void btnCLose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Common1.cart.Clear();
                this.Close();
            }
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            int id = SelectProduct();
            if (id != 0)
            {
                Product pro = ProductControler.Instance.GetProductById(id);
                if (pro.Total - pro.TotalHire - pro.TotalBuy == 0)
                {
                    MessageBox.Show("Sản phẩm hết hàng !");
                    return;
                }
                using (ShowInputTotal continueSale = new ShowInputTotal())
                {
                    continueSale.ShowDetailProduct(id);
                    continueSale.ShowDialog();
                }
            }
            LoadProductSelected();
            if (rbtBuy.Checked)
            {
                LoadBuy();
            }
            else LoadHire();
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
            LoadListProduct();
        }



        private void btnRent_Click_1(object sender, EventArgs e)
        {
            string name = txtNameCus.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            int type = 0;
            int idCus = 0;
            if (!CheckValiInput(name))
            {
                MessageBox.Show("Kiểm tra tên khách hàng !");
                return;
            }
            if (!CheckVailInputEmty(phone))
            {
                MessageBox.Show("Kiểm tra phone !");
                return;
            }
            if (!IsNumber(phone))
            {
                MessageBox.Show("Phone không hợp lệ !");
                return;
            }
            if (!CheckPhone(phone))
            {
                MessageBox.Show("Phone phải đủ 10 số");
                return;
            }
            if (!CheckVailInputEmty(address))
            {
                MessageBox.Show("Kiểm tra địa chỉ !");
                return;
            }
            if (dtgvSelected.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ sản phẩm trống !");
                return;
            }
            // kiem tra ton tai customer
            CustomerController.Instance.InsertCustomer(name, phone, address, DateTime.Today);
            idCus = CustomerController.Instance.GetCustomerByPhone(phone).Id;
           

            if (rbtBuy.Checked)
            {
                type = 1;
            }
            else if (rbtHire.Checked) {
                type = 2;
            }
            // tao ra transaction
            
            TransactionControler.Instance.InsertTransaction(idCus, Common1.Id, type, DateTime.Now);
            int idRecent = TransactionControler.Instance.ReturnIdRecent();


            if (type == 1)
            {
                //them san pham va so luong da mua // dong thoi cap nhat la thong tin san pham
                foreach (Item item in Common1.cart)
                {
                    Product pro = ProductControler.Instance.GetProductById(item.IdProduct);
                    ProductControler.Instance.UpdateProduct(type, item.IdProduct, item.TotalProduct + pro.TotalBuy);
                    TransactionDetailControler.Instance.InsertTransactionDetail(idRecent, item.IdProduct, item.TotalProduct, pro.Price - pro.Discount);

                }
                BuyControler.Instance.InsertBuy(idRecent, Convert.ToDouble(lbTotalPrice.Text), Convert.ToDouble(lbPriceDiscount.Text));
            }
            else if (type == 2)
            {
                //them san pham va so luong da mua // dong thoi cap nhat la thong tin san pham

                foreach (Item item in Common1.cart)
                {
                    Product pro = ProductControler.Instance.GetProductById(item.IdProduct);
                    ProductControler.Instance.UpdateProduct(type, item.IdProduct, item.TotalProduct + pro.TotalHire);
                    TransactionDetailControler.Instance.InsertTransactionDetail(idRecent, item.IdProduct, item.TotalProduct, pro.Price-pro.Discount);

                }
                HireControler.Instance.InsertHire(idRecent, Convert.ToDouble(lbPriceDepositAndReal.Text), Convert.ToDouble(lbTotalPrice.Text), Convert.ToDouble(lbPriceDiscount.Text));
            }
            Common1.cart.Clear();
            if (MessageBox.Show("Thực hiện thành công ?", "Thông báo", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }
        private void txtPhone_Leave(object sender, EventArgs e)
        {
            string phone = txtPhone.Text;
            if (CustomerController.Instance.CheckExistCustomer(phone))
            {
                Customer cus = CustomerController.Instance.GetCustomerByPhone(phone);
                txtNameCus.Text = cus.Name;
                txtAddress.Text = cus.Address;
            }
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
        private void rbtBuy_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtBuy.Checked)
            {
                LoadBuy();
            }
        }

        private void rbtHire_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtHire.Checked)
            {
                LoadHire();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            int id = SelectedProduct();
            if (id != 0)
            {
                using (EditTotalInput edit = new EditTotalInput())
                {
                    edit.ShowDetailProduct(id);
                    edit.ShowDialog();
                }
            }
            LoadProductSelected();
            if (rbtBuy.Checked)
            {
                LoadBuy();
            }
            else LoadHire();
        }

        



        #endregion
        // khi ma nut mua duoc chon

    }
}
