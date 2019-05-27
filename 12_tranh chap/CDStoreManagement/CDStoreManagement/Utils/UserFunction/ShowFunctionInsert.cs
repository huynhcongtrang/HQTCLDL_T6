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

namespace CDStoreManagement.Utils.EmplyeeFunction
{
    public partial class ShowFunctionInsert : Form
    {
        int position;
        string image = "";
        public ShowFunctionInsert()
        {
            InitializeComponent();
        }

        #region method
        private bool isNullOrEmpty(PictureBox pb)
        {
            return pb == null || pb.Image == null;
        }

        private string changeTextEncrypt(string password)
        {
            return Utils.EncryptedPassword.encrypt(password);
        }

        private bool CheckName(string name)
        {
            if (name.Equals("") || !Regex.IsMatch(name, @"^[\p{L}\p{M}' \.\-]+$"))
            {
                return false;
            }
            return true;
        }

        private bool CheckEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool CheckUsername(string username)
        {
            if (username.Equals("") || !Regex.IsMatch(username, @"^(?=[a-zA-Z])[-\w.]{0,23}([a-zA-Z\d]|(?<![-.])_)$"))
            {
                return false;
            }
            return true;
        }
        private bool CheckPhone(string phone)
        {

            if (phone.Equals(""))
            {
                return false;
            }
            return true;
        }

        private bool CheckAddress(string address)
        {
            if (address.Equals(""))
            {
                return false;
            }
            return true;
        }

        private bool CheckPassword(string password)
        {
            if (password.Equals("") || !Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$"))
            {
                return false;
            }
            return true;
        }
        bool CheckValidPrice(string price)
        {
            var result = Decimal.TryParse(price, out decimal d);
            if (result && d != 0)
            {
                return true;
            }

            return false;
        }
        #endregion
        #region event

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btmUploadImage_Click(object sender, EventArgs e)
        {
            image = Common1.UploadImage();
            imagePerson.ImageLocation = image;
        }
        #endregion
        private void cbbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbbPosition.SelectedItem as string;
            String[] codePosition = name.Split('.');
            int code = int.Parse(codePosition[0]);
            position = code;
        }

        private void ShowFunctionInsert_Load(object sender, EventArgs e)
        {
            List<string> lstPosition = new List<string> { "2.Nhân Viên", "3.Nhân Viên Kho" };
            cbbPosition.DataSource = lstPosition;
            tbSalary.Text = Common1.salaryBasic;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string repassword = tbRePassword.Text;
            string email = tbEmail.Text;
            string phone = tbPhone.Text;
            string address = tbAddress.Text;
            string salary = tbSalary.Text;
            string sex = cbbSex.Text;
            string yearBirth = cbbYearBirth.Text;
            if (!CheckName(name))
            {
                MessageBox.Show("Kiểm tra lại Họ và tên !");
                return;
            }
            else if (!CheckUsername(username))
            {
                MessageBox.Show("Kiểm tra lại Tên đăng nhập !");
                return;
            }
            else if (!CheckEmail(email))
            {
                MessageBox.Show("Kiểm tra lại Email !");
                return;
            }
            else if (!CheckPhone(phone))
            {
                MessageBox.Show("Kiểm tra lại số điện thoại !");
                return;
            }
            else if (!CheckAddress(address))
            {
                MessageBox.Show("Kiểm tra lại Địa chỉ !");
                return;
            }
            else if (!CheckValidPrice(salary))
            {
                MessageBox.Show("Kiểm tra lại Lương !");
                return;
            }
            else if (!CheckPassword(password))
            {
                MessageBox.Show("Kiểm tra lại Mật khẩu !");
                return;
            }
            else if (!password.Equals(repassword))
            {
                MessageBox.Show("Mật khẩu nhập lại không giống !");
                return;
            }
            else if (UserControler.Instance.CheckExitUsernameAccount(0, username))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại !");
                return;
            }
            else if (UserControler.Instance.CheckExitEmailAccount(0, email))
            {
                MessageBox.Show("Email đã tồn tại !");
                return;
            }

            else
            {
                string encryPassword = EncryptedPassword.encrypt(password);
                string encryRepassword = EncryptedPassword.encrypt(repassword);
                UserControler.Instance.Register(name,sex,Convert.ToInt16(yearBirth), username, encryPassword, encryRepassword, email, phone, address, position, Convert.ToDouble(salary), image, DateTime.Today);
                MessageBox.Show("Thêm thành công ");
                this.Close();
            }
        }
    }
}
