using CDStoreManagement.Common;
using CDStoreManagement.Controllers;
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

namespace CDStoreManagement.Utils.AccountFunction
{
    public partial class ChangePasswordFunction : Form
    {
        public ChangePasswordFunction()
        {
            InitializeComponent();
        }

        private void ChangePasswordFunction_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool CheckPassword(string password)
        {
            if (password.Equals("") || !Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$"))
            {
                return false;
            }
            return true;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            string password = txtBoxPasswordNew.Text;
            string repassword = txtBoxPasswordNewAgain.Text;
            if (!CheckPassword(password))
            {
                MessageBox.Show("Kiểm tra lại Mật khẩu !");
                return;
            }
            else if (!password.Equals(repassword))
            {
                MessageBox.Show("Mật khẩu nhập lại không giống !");
                return;
            }
            string encryPassword = EncryptedPassword.encrypt(password);
            // cập nhật mật khẩu tại đây.
            UserControler.Instance.UpdatePasswordUserById(Common1.Id,encryPassword);
            MessageBox.Show("Cập nhật thành công !");
            this.Close();
        }
    }
}
