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

namespace CDStoreManagement.Utils.PayProductOfTransaction
{
    public partial class InputDamage : Form
    {
        public InputDamage()
        {
            InitializeComponent();
        }
        private int idProd;
        #region method 
        ItemReview GetItemReview(int idPro) {
            foreach (ItemReview item in PayProduct.listItemReview) {
                if (item.IdProduct == idPro) {
                    return item;
                }
            }
            return null;
        }

        bool UpdateTotalDamage(int idPro , int totalDamage )
        {
            foreach (ItemReview item in PayProduct.listItemReview)
            {
                if (item.IdProduct == idPro)
                {
                    item.TotalDamage = totalDamage;
                    return true;
                }
            }
            return false;
        }

        public void ShowDetailProduct(int idPro) {
            idProd = idPro;
            Product pro = ProductControler.Instance.GetProductById(idPro);
            ItemReview item = GetItemReview(idPro);
            txtNameProduct.Text = pro.Name;
            lbCountExistProduct.Text = item.TotalProduct.ToString() ;
            txtInputTotalProduct.Text = item.TotalDamage.ToString();
        }
        #endregion

        #region event
        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            ItemReview item = GetItemReview(idProd);
            int totalDamage = Convert.ToInt32(txtInputTotalProduct.Text);
            if (totalDamage < 0 || totalDamage > item.TotalProduct) {
                MessageBox.Show("Vui lòng kiểm tra số lượng vừa nhập !");
                return;
            }
            UpdateTotalDamage(idProd, totalDamage);
            this.Close();
        }
        #endregion


    }
}
