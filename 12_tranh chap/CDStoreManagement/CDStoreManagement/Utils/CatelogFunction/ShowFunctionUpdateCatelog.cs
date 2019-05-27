using CDStoreManagement.Controllers;
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

namespace CDStoreManagement.Utils.CatelogFunction
{
    public partial class ShowFunctionUpdateCatelog : Form
    {
        private int idCatalog = 0;
        public ShowFunctionUpdateCatelog()
        {
            InitializeComponent();
        }
        public void DisplayDetailProduct(int id)
        {

            tbNameCatalog.Text = CatalogControler.Instance.GetCatalogById(id).Name;
            idCatalog = id;
        }
        bool CheckValiInput(string value)
        {
            if (value.Equals("") || !Regex.IsMatch(value, @"^[\p{L}\p{M}' \.\-]+$"))
            {
                return false;
            }
            return true;
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbNameCatalog.Text;

            if (!CheckValiInput(name))
            {
                MessageBox.Show("Kiểm tra tên danh mục !");
                return;
            }

            else if (!CatalogControler.Instance.UpdateCatalog(idCatalog, name))
            {
                MessageBox.Show("Danh mục đã tồn tại !");
                return;
            }
            MessageBox.Show("Bạn đã cập nhật thành công !");
            this.Close();
        }
    }
}
