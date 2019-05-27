using CDStoreManagement.Common;
using CDStoreManagement.Controllers;
using CDStoreManagement.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDStoreManagement
{
    public partial class form1 : Form
    {


        public form1()
        {
            InitializeComponent();
        }

        #region event
        private string changeTextEncrypt(string password)
        {
            return Utils.EncryptedPassword.encrypt(password);
        }
        #endregion
        #region method
        bool Login(string username, string password)
        {

            return UserControler.Instance.Login(username, EncryptedPassword.encrypt(password));

        }
        #endregion

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        void SaveDate() {
            for (int i = 0; i < 500; i++) {
                Thread.Sleep(10);
            }
        }
        private void btnControlLogin_Click_1(object sender, EventArgs e)
        {
         
            
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username.Equals(""))
            {
                MessageBox.Show("Tên đăng nhập trống !");
                return;
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("Mật khẩu trống !");
                return;
            }

            if (Login(username, password))
            {
                
                Common1.Id = UserControler.Instance.GetUserByUserName(username).Id;
                Common1.postionPermistion = UserControler.Instance.GetUserByUserName(username).Position;
                Views.Activities.DashboardActivity dashboard = new Views.Activities.DashboardActivity();
                this.Hide();
                dashboard.ShowDialog();
                if (!cbSaveAccount.Checked)
                {
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                };
                this.Show();

            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công !");
            }
        }
    }
}
