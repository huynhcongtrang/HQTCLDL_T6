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
using CDStoreManagement.Common;

namespace CDStoreManagement.Views.Activities
{
    public partial class AccountFragment : UserControl
    {
        public AccountFragment()
        {
            InitializeComponent();
            if (Common1.postionPermistion == Common1.positionNhanVien)
            {
                btnDetailEmployees.Visible = false;
                bunifuFlatButton1.Visible = false;
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnEdit.Visible = false;
                bunifuCustomLabel14.Visible = false;
                bunifuCustomLabel15.Visible = false;
                bunifuCustomLabel16.Visible = false;
            }


        }
        #region method
        void LoadListUser()
        {
            List<User> list = UserControler.Instance.GetListUser();
            LoadListProductFiel(list);
        }
        void DisplayTotal()
        {
            lbTotalUser.Text = UserControler.Instance.GetTotal(0).ToString();
            lbTotalUserAdmin.Text = UserControler.Instance.GetTotal(1).ToString();
            lbTotalUserSell.Text = UserControler.Instance.GetTotal(2).ToString();
            lbTotalUserStock.Text = UserControler.Instance.GetTotal(3).ToString();
        }
        string GetPosition(int pos)
        {
            if (pos == 1)
            {
                return "Quản trị viên";
            }
            if (pos == 2)
            {
                return "Nhân viên";
            }
            if (pos == 3)
            {
                return "Nhân viên kho";
            }
            return "Trống";
        }
        void LoadListEvent()
        {
            EventControler.Instance.RemoveEvent();
            List<Event> list = EventControler.Instance.GetListEvent();
            DataTable dt = new DataTable();

            dt.Columns.Add("Mã", typeof(int));
            dt.Columns.Add("Chủ đề", typeof(string));

            foreach (Event item in list)
            {
                //String.Format("{0:yyyy-MM-dd}", dtDateEvent.Value) + " " + String.Format("{0:HH:mm:ss}", dtTimeEvent.Value);
                dt.Rows.Add(item.Id, item.Title);
            }
            dtgvEvent.ForeColor = Color.Black;
            dtgvEvent.DataSource = dt;
        }
        void LoadListProductFiel(List<User> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã", typeof(int));
            dt.Columns.Add("Họ và Tên", typeof(string));
            dt.Columns.Add("Giới tính", typeof(string));
            dt.Columns.Add("Số điện thoại", typeof(string));
            dt.Columns.Add("Vị trí", typeof(string));
            dt.Columns.Add("Lương", typeof(string));
            dt.Columns.Add("Ngày tạo", typeof(string));

            foreach (User item in list)
            {
                if (item.Position != 1)
                {
                    dt.Rows.Add(item.Id, item.Name, item.Sex, item.Phone, GetPosition(item.Position), item.Salary.ToString("N"), String.Format("{0:dd/MM/yyyy}", item.Created));
                }
            }

            dtgvUser.DataSource = dt;
            DisplayTotal();
        }
        public int SelectUser()
        {
            int id = 0;
            if (dtgvUser.SelectedRows.Count > 0)
            {
                try
                {
                    id = Convert.ToInt16(dtgvUser.SelectedRows[0].Cells["Mã"].Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn không chọn được cái này !");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn người dùng !");
            }
            return id;
        }
        #endregion


        #region event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Utils.EmplyeeFunction.ShowFunctionInsert insert = new Utils.EmplyeeFunction.ShowFunctionInsert())
            {
                insert.ShowDialog();
            }
            LoadListUser();
            DisplayTotal();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int idUser = SelectUser();
            if (idUser != 0)
            {
                using (Utils.EmplyeeFunction.ShowFunctionUpdate update = new Utils.EmplyeeFunction.ShowFunctionUpdate())
                {
                    update.DisplayDetailUser(idUser);
                    update.ShowDialog();

                }
            }
            LoadListUser();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectUser() != 0)
                if ((Common1.Id != SelectUser()))
                {
                    if (MessageBox.Show("Bạn có muốn xoá ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        UserControler.Instance.DeleteUser(SelectUser());
                        LoadListUser();
                        lbNotifi.Text = "Thực hiện thành công !";
                    }

                }
                else
                {
                    MessageBox.Show("Không được xoá người dùng này !");
                }

        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {

            using (Utils.EmplyeeFunction.ShowFunctionUpdateAdmin update = new Utils.EmplyeeFunction.ShowFunctionUpdateAdmin())
            {
                update.DisplayInfo();
                update.ShowDialog();
            }

            LoadInfoAdmin();
        }


        private void btnDetailEmployees_Click(object sender, EventArgs e)
        {

            int idUser = SelectUser();
            if (idUser != 0)
            {
                using (Utils.PersonalDetails.Personal details = new Utils.PersonalDetails.Personal())
                {
                    details.DisplayUserDetail(idUser);
                    details.ShowDialog();
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            string date = DateTime.Now.ToString("dd MMM yyyy");
            string day = DateTime.Now.ToString("dddd");
            btnCalendar.Text = time + "   " + day + "-" + date;
        }

        public void LoadData()
        {
            timer.Start();
            LoadListUser();
            LoadListEvent();
            LoadInfoAdmin();
        }

        void LoadInfoAdmin()
        {
            User u = UserControler.Instance.GetUserById(Common1.Id);
            lbNameAdmin.Text = u.Name;
            if (u.Image_link.Equals(""))
            {
                ImageAdmin.ImageLocation = Common1.imageDefultAdmin;
            }
            else
                ImageAdmin.ImageLocation = u.Image_link;
        }

        private void cbbfill_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<User> list = null;
            if (cbbfill.Text.Equals("Tất cả"))
            {
                LoadListUser();
            }
            else if (cbbfill.Text.Equals("Nhân viên"))
            {
                list = UserControler.Instance.GetListUserFillByPosition(2);
                LoadListProductFiel(list);
            }
            else if (cbbfill.Text.Equals("Nhân viên kho"))
            {
                list = UserControler.Instance.GetListUserFillByPosition(3);
                LoadListProductFiel(list);
            }
        }

        #endregion

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            using (Utils.CalendarEvent.EventNotificationInsert table = new Utils.CalendarEvent.EventNotificationInsert())
            {
                table.ShowDialog();

            }
            LoadListEvent();
        }

        private void dtgvEvent_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                int position = dtgvEvent.HitTest(e.X, e.Y).RowIndex;

                if (position >= 0)
                {
                    contextMenuStrip.Items.Add("Xem chi tiết").Name = "Detail";
                }
                contextMenuStrip.Show(dtgvEvent, new Point(e.X, e.Y));

                //event Click
                 contextMenuStrip.ItemClicked += new ToolStripItemClickedEventHandler(my_itemClicked);
            }
        }
        private void my_itemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "Detail":
                    MessageBox.Show("trang");
                    break;
            }
        }

    }
}
