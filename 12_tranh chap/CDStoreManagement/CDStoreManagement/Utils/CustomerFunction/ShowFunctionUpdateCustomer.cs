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

namespace CDStoreManagement.Utils.CustomerFunction
{
    public partial class ShowFunctionUpdateCustomer : Form
    {

        private int idCustomer = 0;

        public ShowFunctionUpdateCustomer()
        {
            InitializeComponent();
            btnUpdateCustomer.BackColor = Color.SandyBrown;
            btnUpdateCustomer.Normalcolor = Color.SandyBrown;
        }


        //Hiển thị dữ liệu có sẵn
        public void DisplayDetailCustomer(int id)
        {
            idCustomer = id;
            Customer customer = CustomerController.Instance.GetCustomerById(id);
            tbName.Text = customer.Name;
            tbPhone.Text = customer.Phone;
            tbAddress.Text = customer.Address;

        }


        //kiem tra du lieu nhap khong co ki tu dat biet
        bool CheckValiInput(string value)
        {
            if (value.Equals("") || !Regex.IsMatch(value, @"^[\p{L}\p{M}' \.\-]+$"))
            {
                return false;
            }
            return true;
        }

        bool CheckVailInputEmty(string value)
        {
            if (value.Equals(""))
                return false;
            return true;
        }

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        //Kiem tra xem phone có đủ 10 số hay không
        public bool CheckPhone(string pText)
        {
            int number = 0;
            foreach (char chr in pText)
            {
                number += 1;
            }
            if (number == 10)
                return true;
            return false;
        }


        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string phone = tbPhone.Text;
            string address = tbAddress.Text;

            if (!CheckValiInput(name))
            {
                MessageBox.Show("Kiểm tra tên khách hàng !");
                return;
            }
            if (!CheckVailInputEmty(phone))
            {
                MessageBox.Show("Kiểm tra phone !");
                return;
            }
            if (!IsNumber(phone))
            {
                MessageBox.Show("Phone không hợp lệ !");
                return;
            }
            if (!CheckPhone(phone))
            {
                MessageBox.Show("Phone phải đủ 10 số");
                return;
            }

            if (!CheckVailInputEmty(address))
            {
                MessageBox.Show("Kiểm tra địa chỉ !");
                return;
            }
            if (!CustomerController.Instance.UpdateCustomer(idCustomer, name, phone, address))
            {
                MessageBox.Show("Số điện thoại đã tồn tại !");
                return;
            }
            MessageBox.Show("Thực hiện thành công !");
            this.Close();
        }
    }
}
