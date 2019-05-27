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
    public partial class ShowFunctionUpdate : Form
    {
        private string imageLocation = "";
        private int idProduct = 0;
        public ShowFunctionUpdate()
        {
            InitializeComponent();
            LoadCatalog();
        }
        static DialogResult result = DialogResult.No;
        #region method
        void LoadCatalog()
        {
            List<Catalog> list = CatalogControler.Instance.GetListCatalog();
            cbbCatalog.Text = list[0].Name.ToString();
            foreach (Catalog item in list)
            {
                cbbCatalog.Items.Add(item.Name.ToString());
                cbbCatalog.ValueMember = item.Id.ToString();
            }
        }
        string DisplayNameCatalogByIdCatalog(int id)
        {
            return CatalogControler.Instance.GetCatalogById(id).Name;
        }


        public void DisplayDetailProduct(int id)
        {
            idProduct = id;
            Product pro = ProductControler.Instance.GetProductById(id);
            cbbTypeDisk.Text =  DisplayNameCatalogByIdCatalog(pro.IdCatalog);
            cbbTypeDisk.Text = pro.TypeDisk;
            tbNameProduct.Text = pro.Name;
            tbNamePerfor.Text = pro.NamePerfor;
            tbPrice.Text = Convert.ToString(pro.Price);
            tbDiscount.Text = Convert.ToString(pro.Discount);
            tbContent.Text = Convert.ToString(pro.Content);
            tbTotal.Text = Convert.ToString(pro.Total);
            imageProduct.ImageLocation = pro.Image;
            imageLocation = pro.Image;
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
        ////
        #region event

        private void ShowFunctionUpdate_Load(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.LimeGreen;
            btnAdd.Normalcolor = Color.LimeGreen;
            btnCancle.BackColor = Color.Coral;
            btnCancle.Normalcolor = Color.Coral;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes; this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            result = DialogResult.No; this.Close();
        }

        private void btnCancle_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbbCatalog.Text.Equals(""))
            {
                MessageBox.Show("Danh mục trống !");
                return;
            }
            int idCatalog = Convert.ToInt16(cbbCatalog.ValueMember);
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

            //ProductControler.Instance.InsertProduct(idCatalog, typeDisk, name, namePerfor, price, content, discount, imageLocation, total, 0, 0, DateTime.Today);
            if (!ProductControler.Instance.UpdateProduct(idProduct, idCatalog, typeDisk, name, namePerfor, price, content, discount, imageLocation, total)) {
                MessageBox.Show("Sô lượng cập nhật phải lớn hơn số lượng sản phẩm đã giao dịch !");
                return;
            }
            else {
                MessageBox.Show("Bạn đã cập nhật thành công !");
                this.Close();
            }
            
            
        }

        private void btUpImg_Click(object sender, EventArgs e)
        {
            
            imageLocation =  Common1.UploadImage();
            if(!imageLocation.Equals(""))
            imageProduct.ImageLocation = imageLocation;
        }
    }
}
