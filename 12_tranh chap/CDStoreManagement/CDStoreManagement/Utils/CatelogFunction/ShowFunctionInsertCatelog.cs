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
    public partial class ShowFunctionInsertCatelog : Form
    {
        public ShowFunctionInsertCatelog()
        {
            InitializeComponent();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = tbNameCatalog.Text;
            if (!CheckValiInput(name))
            {
                MessageBox.Show("Kiểm tra tên danh mục !");
                return;
            }
            
            if (CatalogControler.Instance.InsertCatalog(name).Equals("SAME_NAME")) {
                MessageBox.Show("Tên danh mục đã tồn tại !");
                return;
            }
            MessageBox.Show("Bạn đã thêm thành công !");
            this.Close();
        }
    }
}
