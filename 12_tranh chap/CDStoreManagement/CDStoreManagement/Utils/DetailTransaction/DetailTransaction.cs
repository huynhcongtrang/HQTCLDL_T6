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

namespace CDStoreManagement.Utils.DetailTransaction
{
    public partial class DetailTransaction : Form
    {
        public DetailTransaction()
        {
            InitializeComponent();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowDetailTransaction(int idTran) {
            Transaction tran = TransactionControler.Instance.GetTransactionById(idTran);
            if (tran.Type == 1)
            {
                lbTypeTransaction.Text = "Mua đĩa";
            }
            else if (tran.Type == 2)
            {
                lbTypeTransaction.Text = "Thuê đĩa";
            }
            else if (tran.Type == 3)
            {
                lbTypeTransaction.Text = "Đã trả";
            }

            //hien thi ngay gio
            lbDateCreated.Text = String.Format("{0:dd-MM-yyyy}", tran.Created);

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

            foreach (TransactionaDetail tranDe in listTranDe)
            {
                Product pro = ProductControler.Instance.GetProductById(tranDe.Id_product);
                dt.Rows.Add(tranDe.Id_product, pro.Name, tranDe.Price.ToString("N") ,tranDe.Total_product);
            }
            dtgvProductTra.ForeColor = Color.Black;
            dtgvProductTra.DataSource = dt;
            if (tran.Type == 1)
            {
                // thue phat coc an
                ptbIconPriceHire.Visible = false;
                lbTitleHire.Visible = false;
                lbPriceHire.Visible = false;
                lbUnitHire.Visible = false;

                pcbFine.Visible = false;
                lbFine.Visible = false;
                lbPriceFine.Visible = false;
                lbUnitFine.Visible = false;

                lbTittleDepositAndReal.Visible = false;
                pcbIconDeposit.Visible = false;
                lbPriceDepositAndReal.Visible = false;
                lbUnitDepositAndReal.Visible = false;

                Buy buy = BuyControler.Instance.GetBuyByIdTransa(idTran);
                lbTotalPrice.Text = buy.Total.ToString("N");
                lbPriceDiscount.Text = buy.Discount.ToString("N");
            }
            else if (tran.Type == 2)
            {
                //  phat  an

                pcbFine.Visible = false;
                lbFine.Visible = false;
                lbPriceFine.Visible = false;
                lbUnitFine.Visible = false;

                Hire hire = HireControler.Instance.GetHireByIdTransa(idTran);
                lbTotalPrice.Text = hire.Total.ToString("N");
                lbPriceHire.Text = (hire.Total - hire.Deposit + hire.Discount).ToString("N");
                lbPriceDepositAndReal.Text = hire.Deposit.ToString("N");
                lbPriceDiscount.Text = hire.Discount.ToString("N");
            }
            else if (tran.Type == 3)
            {

                Hire hire = HireControler.Instance.GetHireByIdTransa(idTran);
                lbTotalPrice.Text = (hire.Total + hire.Expired + hire.Damage).ToString("N");
                lbPriceFine.Text = (hire.Damage + hire.Expired).ToString("N");
                lbPriceHire.Text = (hire.Total + hire.Discount).ToString("N");
                lbPriceDepositAndReal.Text = hire.Deposit.ToString("N");
                lbPriceDiscount.Text = hire.Discount.ToString("N");
            }
        }
    }
}
