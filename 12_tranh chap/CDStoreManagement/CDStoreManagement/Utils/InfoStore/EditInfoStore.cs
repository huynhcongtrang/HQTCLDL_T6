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

namespace CDStoreManagement.Utils.InfoStore
{
    public partial class EditInfoStore : Form
    {
        public EditInfoStore()
        {
            InitializeComponent();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ShowData()
        {
            Info_store info = InFoCompanyControler.Instance.GetInfoStore();
            txtAddress.Text = info.Address;
            txtEmail.Text = info.Email;
            txtPhone.Text = info.Phone;
        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public static bool IsPhoneNumber(string number)
        {
            double Num;
            return double.TryParse(number, out Num);
        }
        private void btnUpdateBuy_Click(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtEmail.Text)) {
                MessageBox.Show("Kiểm tra lại email !");
                return;
            }
            if (!IsPhoneNumber(txtPhone.Text)) {
                MessageBox.Show("Kiểm tra số điện thoại !");
                return;
            }
            InFoCompanyControler.Instance.UpdateInfoStore(txtEmail.Text , txtAddress.Text , txtPhone.Text);
            MessageBox.Show("Cập nhật thành công ");
            this.Close();
        }
    }
}
