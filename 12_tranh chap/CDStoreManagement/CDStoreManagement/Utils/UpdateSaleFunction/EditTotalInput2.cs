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

namespace CDStoreManagement.Utils.UpdateSaleFunction
{
    public partial class EditTotalInput2 : Form
    {
        private int idProduct = 0;
        public EditTotalInput2()
        {
            InitializeComponent();
        }
        #region method
        int FindTotalFromId(int id)
        {
            foreach (Item item in Common1.cart)
            {
                if (item.IdProduct == id)
                {
                    return item.TotalProduct;
                }
            }
            return 0;
        }

       
        int GetTotalProduct(int idProduct, int idTran) {

            List<TransactionaDetail> listTranDe = TransactionDetailControler.Instance.GetListTransactionDetailById(idTran);
            foreach (TransactionaDetail tranDe in listTranDe)
            {
                if (tranDe.Id_product == idProduct)
                {
                    return tranDe.Total_product;
                }
            }
            return 0;
        }
        private int idTransac;
        public void ShowDetailProduct(int id , int idTran)
        {
            idTransac = idTran;
            idProduct = id;
            Product pro = ProductControler.Instance.GetProductById(id);
            txtNameProduct.Text = pro.Name;
            lbCountExistProduct.Text = (pro.Total + GetTotalProduct(id,idTran) - pro.TotalHire - pro.TotalBuy).ToString();
            txtInputTotalProduct.Text = FindTotalFromId(id).ToString();
        }
        bool UpdateTotal(int id, int total)
        {
            foreach (Item item in Common1.cart)
            {
                if (item.IdProduct == id)
                {
                    item.TotalProduct = total;
                    return true;
                }
            }
            return false;
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
            int totalExit = pro.Total + GetTotalProduct(idProduct, idTransac) - pro.TotalHire - pro.TotalBuy;
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
