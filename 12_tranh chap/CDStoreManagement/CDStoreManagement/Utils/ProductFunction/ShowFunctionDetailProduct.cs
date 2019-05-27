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

namespace CDStoreManagement.Utils.ProductFunction
{
    public partial class ShowFunctionDetailProduct : Form
    {
        public ShowFunctionDetailProduct()
        {
            InitializeComponent();
        }

        public void ShowDetailProduct(int idPro) {
            Product pro = ProductControler.Instance.GetProductById(idPro);
            txtNamePro.Text = pro.Name;
            txtCatalog.Text = CatalogControler.Instance.GetCatalogById(pro.IdCatalog).Name;
            txtTypeDisk.Text = pro.TypeDisk;
            txtPerforman.Text = pro.NamePerfor;
            txtContent.Text = pro.Content;
            txtTotal.Text = pro.Total.ToString();
            txtPrice.Text = pro.Price.ToString("N") + " đồng";
            txtCreated.Text = String.Format("{0:dd - MM - yyyy}", pro.Created);
            ptbProduct.ImageLocation = pro.Image;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
