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

namespace CDStoreManagement.Utils
{
    public partial class ShowFunctionInsert : Form
    {
        private string imageLocation = "";

        public ShowFunctionInsert()
        {
            InitializeComponent();
            LoadCatalog();
        }
        

        #region method
        void LoadCatalog()
        {
            List<Catalog> list = CatalogControler.Instance.GetListCatalog();
            cbbCatalog.Text = list[0].Name.ToString();
            foreach (Catalog item in list)
            {
                cbbCatalog.Items.Add(item.Name.ToString());
            }
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
        // kieemr tra phai tien khong
        bool CheckValidPrice(string price)
        {
            var result = Decimal.TryParse(price, out decimal d);
            if (result && d >= 0)
            {
                return true;
            }

            return false;
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        #endregion
        private void CustomMessageBoxAnimated_Load(object sender, EventArgs e)
        {
            
            btnAdd.BackColor = Color.LimeGreen;
            btnAdd.Normalcolor = Color.LimeGreen;
            btnCancle.BackColor = Color.Coral;
            btnCancle.Normalcolor = Color.Coral;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbbCatalog.Text.Equals(""))
            {
                MessageBox.Show("Danh mục trống !");
                return;
            }
            int idCatalog = CatalogControler.Instance.GetCatalogByName(cbbCatalog.Text).Id;
            string typeDisk = cbbTypeDisk.Text;
            string name = tbNameProduct.Text;
            string namePerfor = tbNamePerfor.Text;
            string content = tbContent.Text;
            Decimal price;
            Decimal discount;
            int total;
            if (!CheckValiInput(name))
            {
                MessageBox.Show("Kiểm tra tên đĩa !");
                return;
            }
            else if (!CheckValiInput(namePerfor))
            {
                MessageBox.Show("Kiểm tra Tên ca sĩ (diễn viên) !");
                return;
            }
            else if (!CheckValiInput(content))
            {
                MessageBox.Show("Kiểm tra Nội dung !");
                return;
            }
            if (!CheckValidPrice(tbPrice.Text))
            {
                MessageBox.Show("Kiểm tra Giá đĩa !");
                return;
            }
            else
            {
                price = Convert.ToDecimal(tbPrice.Text.ToString());
            }
            if (!CheckValidPrice(tbDiscount.Text))
            {
                MessageBox.Show("Kiểm tra Giảm giá !");
                return;
            }
            else
            {
                discount = Convert.ToDecimal(tbDiscount.Text.ToString());
            }
            if (price < discount)
            {
                MessageBox.Show("Kiểm tra Giảm giá !");
                return;
            }
            if (tbTotal.Text.Equals("") || !IsNumber(tbTotal.Text))
            {
                MessageBox.Show("Kiểm tra Số lượng !");
                return;
            }
            else
            {
                total = Convert.ToInt16(tbTotal.Text);
            }

            ProductControler.Instance.InsertProduct(idCatalog, typeDisk, name, namePerfor, price, content, discount, imageLocation, total, 0, 0, DateTime.Today);

            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUploadImage(object sender, EventArgs e)
        {
            imageLocation = Common1.UploadImage();
            if (!imageLocation.Equals(""))
                imageProduct.ImageLocation = imageLocation;
        }

       
    }
}
