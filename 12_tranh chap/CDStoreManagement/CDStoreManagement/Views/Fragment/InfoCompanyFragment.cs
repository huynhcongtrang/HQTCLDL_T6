using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDStoreManagement.Models;
using CDStoreManagement.Controllers;
using CDStoreManagement.Common;

namespace CDStoreManagement.Views.Fragment
{
    public partial class InfoCompanyFragment : UserControl
    {
        public InfoCompanyFragment()
        {
            InitializeComponent();
            if (Common1.postionPermistion == Common1.positionNhanVien) {
                btnReset.Visible = false;
            }
        }


        #region method
        public void LoadData() {
            Info_store info = InFoCompanyControler.Instance.GetInfoStore();
            txtEmail.Text = info.Email;
            txtPhone.Text = info.Phone;
            txtAddress.Text = info.Address;
        }
        #endregion
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            using (Utils.InfoStore.EditInfoStore edit = new Utils.InfoStore.EditInfoStore())
            {
                edit.ShowData();
                edit.ShowDialog();
            }
            LoadData();
        }
    }
}
