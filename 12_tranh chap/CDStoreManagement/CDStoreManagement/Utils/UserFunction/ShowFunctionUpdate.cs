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
    public partial class ShowFunctionUpdate : Form
    {
        private string image = "";
        private int position;
        private int idUser;
        public ShowFunctionUpdate()
        {
            InitializeComponent();
        }
        #region method
        public void SelectItemByValue(ComboBox cbo, string value)
        {
            for (int i = 0; i < cbo.Items.Count; i++)
            {
                var prop = cbo.Items[i].GetType().GetProperty(cbo.ValueMember);
                if (prop != null && prop.GetValue(cbo.Items[i], null).ToString() == value)
                {
                    cbo.SelectedIndex = i;
                    break;
                }
            }
        }
        public void DisplayDetailUser(int id)
        {
            idUser = id;
            User us = UserControler.Instance.GetUserById(id);
            txtName.Text = us.Name;
            txtEmail.Text = us.Email;
            txtPhone.Text = us.Phone;
            txtAddress.Text = us.Address;
            cbbSex.Text = us.Sex;
            cbbYearBirth.Text = us.YearBirth.ToString();
            imagePerson.ImageLocation = us.Image_link;
            if (Common1.Id == id) {
                tbSalary.Enabled = false;
            }else
            tbSalary.Text = us.Salary.ToString();
            position = us.Position;
        }
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
            if (!password.Equals(""))
                if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$"))
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


        private void btnInsert_Click(object sender, EventArgs e)
        {

            string name = txtName.Text;
            string password = txtPassword.Text;
            string repassword = txtRePassword.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string salary = tbSalary.Text;
            string sex = cbbSex.Text;
            string yearBirth = cbbYearBirth.Text;
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
            else if (UserControler.Instance.CheckExitEmailAccount(idUser, email))
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
                int tempPosition = SelectCombobox(cbbPosition);
                UserControler.Instance.UpdateUser(idUser, name,sex,Convert.ToInt16(yearBirth), password, email, phone, address, tempPosition, Convert.ToDouble(salary), imagePerson.ImageLocation);
                MessageBox.Show("Cập nhật thành công");
                this.Close();
            }
        }

        #endregion




        private int SelectCombobox(ComboBox box)
        {
            string name = cbbPosition.SelectedItem as string;
            String[] codePosition = name.Split('.');
            int code = int.Parse(codePosition[0]);
            return code;
        }

        private void ShowFunctionUpdate_Load_1(object sender, EventArgs e)
        {
            List<string> lstPosition = new List<string> { "2.Nhân Viên", "3.Nhân Viên Kho" };
            cbbPosition.DataSource = lstPosition;
            cbbPosition.Text = lstPosition[position - 2];
        }

        private void btmUploadImage_Click_1(object sender, EventArgs e)
        {
            image = Common1.UploadImage();
            if (!image.Equals(""))
                imagePerson.ImageLocation = image;
        }

    }
}
