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

namespace CDStoreManagement.Utils.PersonalDetails
{
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
        }

        #region method
        public void DisplayUserDetail(int id) {
            User us = UserControler.Instance.GetUserById(id);
            txtId.Text = id.ToString();
            txtYearBirth.Text = us.YearBirth.ToString();
            txtSex.Text = us.Sex;
            txtUsername.Text = us.Username;
            txtAddress.Text = us.Address;
            txtCreatedDay.Text = String.Format("{0:dd-MM-yyyy}", us.Created);
            txtPhone.Text = us.Phone;
            txtMail.Text = us.Email;
            txtName.Text = us.Name;
            if (us.Position == 1) {
                txtPosition.Text = "Quản trị viên";
            }else
            txtPosition.Text = (us.Position == 3) ? "Nhân viên kho" : "Nhân viên";
            circlePersonal.ImageLocation = us.Image_link;
        }
        #endregion

        #region event
        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
