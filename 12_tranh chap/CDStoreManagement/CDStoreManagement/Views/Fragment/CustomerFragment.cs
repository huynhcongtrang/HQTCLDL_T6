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
using System.Globalization;
using CDStoreManagement.Common;

namespace CDStoreManagement.Views.Fragment
{
    public partial class CustomerFragment : UserControl
    {
        public CustomerFragment()
        {
            InitializeComponent();
            if (Common1.postionPermistion == Common1.positionNhanVien) {
                btnDelete.Visible = false;
                bunifuCustomLabel16.Visible = false;
            }
        }



        #region method
        void LoadListFiel(List<Customer> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã", typeof(int));
            dt.Columns.Add("Tên khách hàng", typeof(string));
            dt.Columns.Add("Điện thoại", typeof(string));
            dt.Columns.Add("Địa chỉ", typeof(string));
            dt.Columns.Add("Ngày lập", typeof(DateTime));
            CultureInfo culture = new CultureInfo("vi-VN");
            foreach (Customer item in list)
            {
                dt.Rows.Add(item.Id, item.Name, item.Phone, item.Address, item.Created);

            }

            dgvCustomer.ForeColor = Color.Black;
            dgvCustomer.DataSource = dt;
        }
        void LoadListCustomer()
        {
            List<Customer> list = CustomerController.Instance.GetListCustomer();
            LoadListFiel(list);
        }

        public void LoadData()
        {
            LoadListCustomer();
            lbTotalCustomer.Text = CustomerController.Instance.GetTotal(1).ToString();
        }

        public int SelectCustomer()
        {
            int id = 0;
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                try
                {
                    id = Convert.ToInt16(dgvCustomer.SelectedRows[0].Cells["Mã"].Value.ToString());
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
        //Them khach hang


        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Utils.CustomerFunction.ShowFunctionInsertCustomer insert = new Utils.CustomerFunction.ShowFunctionInsertCustomer())
            {
                insert.ShowDialog();
                LoadData();
            }
        }


        //Sửa khách hàng
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int idCustomer = SelectCustomer();
            if (idCustomer != 0)
            {
                using (Utils.CustomerFunction.ShowFunctionUpdateCustomer update = new Utils.CustomerFunction.ShowFunctionUpdateCustomer())
                {
                    update.DisplayDetailCustomer(idCustomer);
                    update.ShowDialog();
                }
            }
            LoadListCustomer();
        }


        //xoá khách hàng
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int idCustomer = SelectCustomer();
            if (idCustomer != 0)
            {
                if (MessageBox.Show("Bạn có muốn xoá ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    if (TransactionControler.Instance.CheckExitUserIntoTran(idCustomer)) {
                        MessageBox.Show("Thực hiện không thành công ! Khách hàng đã giao dịch ");
                        return;
                    }
                    CustomerController.Instance.DeleteCustomer(idCustomer);
                    LoadData();
                }
            }

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = tbKeyWord.Text;
            if (key.Equals("Tìm kiếm . . ."))
            {
                MessageBox.Show("Bạn chưa nhập vào từ khoá !");
                return;
            }
            List<Customer> list = CustomerController.Instance.SearchCustomer(key);
            LoadListFiel(list);
        }

        #endregion

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadListCustomer();
            tbKeyWord.Text = "Tìm kiếm . . .";
        }
        
    }
}
