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
    public partial class EditTotalInput : Form
    {
        private int idProduct = 0;
        public EditTotalInput()
        {
            InitializeComponent();
        }
        #region method
        int FindTotalFromId(int id) {
            foreach (Item item in Common1.cart) {
                if (item.IdProduct == id) {
                    return item.TotalProduct;
                }
            }
            return 0;
        }
        public void ShowDetailProduct(int id) {
            idProduct = id;
            Product pro = ProductControler.Instance.GetProductById(id);
            txtNameProduct.Text = pro.Name;
            lbCountExistProduct.Text = (pro.Total - pro.TotalHire - pro.TotalBuy).ToString();
            txtInputTotalProduct.Text = FindTotalFromId(id).ToString();
        }
        bool UpdateTotal(int id, int total) {
            foreach (Item item in Common1.cart)
            {
                if (item.IdProduct == id)
                {
                    item.TotalProduct = total;
                    return true;
                }
            }
            return false ;
        }
        #endregion

        #region event
        private void btSend_Click(object sender, EventArgs e)
        {
            Product pro = ProductControler.Instance.GetProductById(idProduct);
            double Num;
            if (!double.TryParse(txtInputTotalProduct.Text, out Num))
            {
                MessageBox.Show("Kiểm tra lại số lượng sản phẩm");
                return;
            }
            int totalExit = pro.Total - pro.TotalHire - pro.TotalBuy;
            int totalInput = Convert.ToInt32(txtInputTotalProduct.Text);
            if (totalInput > totalExit)
            {
                MessageBox.Show("Số lượng đĩa quá lớn");
                return;
            }

            UpdateTotal(idProduct, totalInput);
            this.Close();
        }

        #endregion

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
