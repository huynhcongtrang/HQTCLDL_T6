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

namespace CDStoreManagement.Utils.EmplyeeFunction
{
    public partial class ShowFunctionUpdateAdmin : Form
    {
        private string image = "";
        public ShowFunctionUpdateAdmin()
        {
            InitializeComponent();
        }
        #region method
        public void DisplayInfo()
        {
            User us = UserControler.Instance.GetUserById(Common1.Id);
            txtName.Text = us.Name;
            txtAddress.Text = us.Address;
            txtEmail.Text = us.Email;
            txtPhone.Text = us.Phone;
            imagePerson.ImageLocation = us.Image_link;
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
            if (!password.Equals(""))
                if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$"))
                {
                    return false;
                }
            return true;
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
            if (!image.Equals(""))
                imagePerson.ImageLocation = image;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string password = txtPassword.Text;
            string repassword = txtRePassword.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            if (!CheckName(name))
            {
                MessageBox.Show("Kiểm tra lại Họ và tên !");
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
            
            
            else if (UserControler.Instance.CheckExitEmailAccount(Common1.Id, email))
            {
                MessageBox.Show("Email đã tồn tại !");
                return;
            }

            else
            {

                if (!password.Equals(""))
                {
                    password = EncryptedPassword.encrypt(password);
                }
                else password = "";
                UserControler.Instance.UpdateUser(Common1.Id, name, "Nam", 1998, password, email, phone, address, 1, 0, imagePerson.ImageLocation);
                MessageBox.Show("Cập nhật thành công");
                this.Close();
            }
            #endregion


        }
    }
}
