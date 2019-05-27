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

namespace CDStoreManagement.Utils.SurveyChange
{
    public partial class InputChangeSurvey : Form
    {
        private int countProduct = 0;
        private int idProduct = 0;
        public InputChangeSurvey()
        {
            InitializeComponent();
        }
        #region method
        public bool CheckNuberInput(string number) {
            int n;
            if (!int.TryParse(number, out n) || (Convert.ToInt32(number) < 0) || (Convert.ToInt32(number) > countProduct)) {
                return false;
            }
            return true;
        }
        public ItemSurvey FindIdPro(int idPro) {
            foreach (ItemSurvey item in FunctionSurveyChange.listItemSurvey) {
                if (item.Id_Product == idPro) {
                    return item;
                }
            }
            return null;
        }
        
        public void ShowDetailProduct(int idPro) {
            idProduct = idPro;
            Product pro = ProductControler.Instance.GetProductById(idPro);
            txtNameProduct.Text = pro.Name;
            ItemSurvey item =  FindIdPro(idPro);
            countProduct = item.Total_Product;
            lbCountExistProduct.Text = countProduct.ToString();
            txtInputTotalProduct.Text = item.Total_Change.ToString();
        }
        #endregion

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void UpdateTotalChange(int idPro, int totalChange)
        {
            foreach (ItemSurvey item in FunctionSurveyChange.listItemSurvey)
            {
                if (item.Id_Product == idPro)
                {
                    item.Total_Change = totalChange;
                }
            }
        }
        private void btSend_Click(object sender, EventArgs e)
        {
            string NumberInput = txtInputTotalProduct.Text;
            if (!CheckNuberInput(NumberInput)) {
                MessageBox.Show("Kiểm tra lại số lượng vừa nhập !");
                return;
            }
            UpdateTotalChange(idProduct,Convert.ToInt32(NumberInput));
            this.Close();
        }
    }
}
