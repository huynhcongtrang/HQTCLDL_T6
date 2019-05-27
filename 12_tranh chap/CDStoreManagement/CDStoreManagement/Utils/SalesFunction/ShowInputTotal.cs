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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDStoreManagement.Utils.SalesFunction
{
    public partial class ShowInputTotal : Form
    {
        private int idProduct = 0; 
        public ShowInputTotal()
        {
            InitializeComponent();
        }

        #region method
        public void ShowDetailProduct(int id) {
            idProduct = id;
            Product pro = ProductControler.Instance.GetProductById(id);
            txtNameProduct.Text = pro.Name;
            lbCountExistProduct.Text = (pro.Total - pro.TotalHire - pro.TotalBuy).ToString();
        }
        public bool ProductIntoCart(Item item)
        {
            foreach (Item i in Common1.cart)
            {
                if (i.IdProduct == item.IdProduct)
                {
                    Product pro = ProductControler.Instance.GetProductById(item.IdProduct);
                    if ((i.TotalProduct + item.TotalProduct) > (pro.Total - pro.TotalHire- pro.TotalBuy)) {
                        MessageBox.Show("Vui lòng kiểm tra lại số lượng");
                        return false;
                    }
                    i.TotalProduct += item.TotalProduct;
                    return true;
                }
            }
            Common1.cart.Add(item);
            return false;
        }
        #endregion

        #region event
        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            Product pro = ProductControler.Instance.GetProductById(idProduct);
            double Num;
            if (!double.TryParse(txtInputTotalProduct.Text, out Num)) {
                MessageBox.Show("Kiểm tra lại số lượng sản phẩm");
                return;
            }
            int totalExit = pro.Total - pro.TotalHire - pro.TotalBuy;
            int totalInput = Convert.ToInt32(txtInputTotalProduct.Text);
            if (totalInput > totalExit) {
                MessageBox.Show("Số lượng đĩa quá lớn");
                return;
            }
            
            Item item = new Item(idProduct, totalInput);
            ProductIntoCart(item);
            this.Close();
        }
        #endregion
    }
}
