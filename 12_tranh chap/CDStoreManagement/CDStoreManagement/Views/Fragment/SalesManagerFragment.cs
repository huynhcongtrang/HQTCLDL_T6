using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDStoreManagement.Models;
using CDStoreManagement.Controllers;
using CDStoreManagement.Utils;
using CDStoreManagement.Utils.UpdateSaleFunction;
using CDStoreManagement.Utils.DetailTransaction;
using CDStoreManagement.Utils.PayProductOfTransaction;
using CDStoreManagement.Utils.SurveyChange;
using CDStoreManagement.Common;

namespace CDStoreManagement.Views.Activities
{
    public partial class SalesManagerFragment : UserControl
    {
        public SalesManagerFragment()
        {
            InitializeComponent();
            if (Common1.postionPermistion == Common1.positionNhanVien) {
                btnDelete.Visible = false;
                bunifuCustomLabel2.Visible = false;
            }
        }


        #region method
        string GetTypeTransaction(int type)
        {
            if (type == 1)
            {
                return "Mua đĩa";
            }
            else if (type == 2)
            {
                return "Thuê đĩa";
            }
            else if (type == 3)
            {

                return "Đã trả";
            }
            return "null";
        }
        void LoadListTransactionFiel(List<Transaction> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã", typeof(int));
            dt.Columns.Add("Tên khách hàng", typeof(string));
            dt.Columns.Add("Số điện thoại", typeof(string));
            dt.Columns.Add("Trạng thái", typeof(string));
            dt.Columns.Add("Ngày tạo", typeof(string));

            foreach (Transaction item in list)
            {
                Customer cu = CustomerController.Instance.GetCustomerById(item.Id_customer);
                dt.Rows.Add(item.Id, cu.Name, cu.Phone, GetTypeTransaction(item.Type), String.Format("{0:dd-MM-yyyy}", item.Created));
            }
            lbDateChange.Text = RuleBuyControler.Instance.GetRuleBuy(Common1.idRuleBuy).Number_date_change.ToString(); ;
            lbDatePay.Text = RuleHireControler.Instance.GetRuleHire(Common1.idRuleHire).Number_date_pay.ToString();
            dtgvListTransaction.ForeColor = Color.Black;
            dtgvListTransaction.DataSource = dt;
        }
        public void LoadListTransaction()
        {
            List<Transaction> list = TransactionControler.Instance.GetListTransaction();
            LoadListTransactionFiel(list);

        }
        public void LoadTotalTransaction()
        {
            lbTotalTransaction.Text = TransactionControler.Instance.GetTotal(0).ToString();
            lbTotalHire.Text = TransactionControler.Instance.GetTotal(2).ToString();
            lbTotalBuy.Text = TransactionControler.Instance.GetTotal(1).ToString();
            lbTotalPaied.Text = TransactionControler.Instance.GetTotal(3).ToString();
        }


        public int SelectTransaction()
        {
            int id = 0;
            if (dtgvListTransaction.SelectedRows.Count > 0)
            {
                try
                {
                    id = Convert.ToInt16(dtgvListTransaction.SelectedRows[0].Cells["Mã"].Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn không chọn được cái này !");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn Giao dich !");
            }
            return id;
        }
       
        #endregion

        #region event
        private void SalesManagerFragment_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string queryExtend = "";
            //Tìm kiếm . . .;
            string id = tbId.Text;
            string phone = tbPhoneCus.Text;
            if (!id.Equals("Tìm kiếm . . ."))
            {
                queryExtend = " and a.id = " + Convert.ToInt32(id);
            }
            if (!phone.Equals("Tìm kiếm . . ."))
            {
                queryExtend += " and b.phone like " + phone;
            }
            queryExtend += " and CAST(a.created AS DATE) = CAST('" + String.Format("{0:yyyy-MM-dd}", dtTransaction.Value) + "' AS DATE)";
            dtgvListTransaction.DataSource = TransactionControler.Instance.GetListTransactionWhere(queryExtend);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadListTransaction();
            tbId.Text = "Tìm kiếm . . .";
            tbPhoneCus.Text = "Tìm kiếm . . .";
            dtTransaction.Value = DateTime.Today;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Utils.SalesFunction.ShowFunctionRent rent = new Utils.SalesFunction.ShowFunctionRent())
            {
                rent.ShowDialog();
            }
            
            LoadListTransaction();
            LoadTotalTransaction();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int idTrannsaction = SelectTransaction();
            if (idTrannsaction != 0)
            {
                Transaction tran = TransactionControler.Instance.GetTransactionById(idTrannsaction);
                int type = tran.Type;
                if (type == 1)
                {
                    BuyControler.Instance.DeleteBuy(idTrannsaction);
                }
                else
                {
                    HireControler.Instance.DeleteHire(idTrannsaction);
                }
                TransactionDetailControler.Instance.DeleteTransactionDetail(idTrannsaction);
                TransactionControler.Instance.DeleteTransaction(idTrannsaction);
                MessageBox.Show("Thành công !");
                LoadListTransaction();
                LoadTotalTransaction();
            }
        }

        #endregion

        private void btUpdateTransaction_Click(object sender, EventArgs e)
        {
            int idTrannsaction = SelectTransaction();
            
            if (idTrannsaction != 0)
            {
                Transaction tran = TransactionControler.Instance.GetTransactionById(idTrannsaction);
                int type = tran.Type;
                if (type == 3)
                {
                    MessageBox.Show("Giao dịch không được áp dụng hành động này !");
                    return;
                }
                if ((DateTime.Now - tran.Created).TotalDays > RuleBuyControler.Instance.GetRuleBuy(Common1.idRuleBuy).Number_date_change)
                {
                    MessageBox.Show("Hành động này đã quá thời gian cho phép !");
                    return;
                }
                using (ShowFunctionUpdateTransaction update = new ShowFunctionUpdateTransaction())
                {
                    update.ShowDetailTransaction(idTrannsaction);
                    update.ShowDialog();
                }
                LoadListTransaction();
                LoadTotalTransaction();
            }
        }

        private void btDetail_Click(object sender, EventArgs e)
        {
            int idTrannsaction = SelectTransaction();
            if (idTrannsaction != 0)
            {
                using (DetailTransaction detailTran = new DetailTransaction())
                {
                    detailTran.ShowDetailTransaction(idTrannsaction);
                    detailTran.ShowDialog();
                }

            }
        }

        private void btPay_Click(object sender, EventArgs e)
        {
            int idTrannsaction = SelectTransaction();
            
            if (idTrannsaction != 0)
            {
                int type = TransactionControler.Instance.GetTransactionById(idTrannsaction).Type;
                if (type == 1 || type == 3)
                {
                    MessageBox.Show("Giao dịch không được áp dụng hành động này !");
                    return;
                }
                using (PayProduct payPro = new PayProduct())
                {
                    payPro.ShowDetailTransaction(idTrannsaction);
                    payPro.ShowDialog();
                }
                LoadListTransaction();
            }
        }

        private void btChange_Click(object sender, EventArgs e)
        {

            int idTrannsaction = SelectTransaction();
            if (idTrannsaction != 0)
            {
                Transaction tran = TransactionControler.Instance.GetTransactionById(idTrannsaction);
                int type = tran.Type;
                if (type == 2 || type == 3)
                {
                    MessageBox.Show("Hành động không áp dụng cho giao dịch này !");
                    return;
                }

                if ((DateTime.Now - tran.Created).TotalDays > RuleBuyControler.Instance.GetRuleBuy(Common1.idRuleBuy).Number_date_change) {
                    MessageBox.Show("Hành động này đã quá thời gian cho phép !");
                    return;
                }

                using (FunctionSurveyChange survey = new FunctionSurveyChange())
                {
                    survey.ShowDetailTransaction(idTrannsaction);
                    survey.ShowDialog();
                }
            }
        }

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = cbbType.Text;
            string queryExtend = "";
            if (key.Equals("Tất cả"))
            {
                LoadListTransaction();
                return;
            }
            else if (key.Equals("Đã mua")) {
                queryExtend = " and type = 1";
            } else if (key.Equals("Đã thuê")) {
                queryExtend = " and type = 2";
            }
            else if (key.Equals("Đã trả thuê"))
            {
                queryExtend = " and type = 3";
            }
            dtgvListTransaction.DataSource = TransactionControler.Instance.GetListTransactionWhere(queryExtend);
        }
    }
}
