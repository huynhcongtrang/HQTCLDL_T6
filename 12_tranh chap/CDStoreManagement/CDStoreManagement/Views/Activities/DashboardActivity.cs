using CDStoreManagement.Common;
using CDStoreManagement.Controllers;
using CDStoreManagement.Models;
using CDStoreManagement.Views.Fragment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDStoreManagement.Views.Activities
{
    public partial class DashboardActivity : Form
    {
        public DashboardActivity()
        {
            InitializeComponent();
            welcomFragment1.BringToFront();
            DisplayInit();
            if (Common1.postionPermistion == Common1.positionNhanVienKho) {
                btnQLBH.Enabled = false;
                btnTK.Enabled = false;
                btnBC.Enabled = false;
                btnAccount.Enabled = false;
                btnKHang.Enabled = false;
                btnInform.Enabled = false;
                btnRules.Enabled = false;
            }
        }
        void DisplayInit() {
            User u = UserControler.Instance.GetUserById(Common1.Id);
            if (u.Position == 1) {
                lbHello.Text = "Xin chào Quản trị viên";
            }
            else if (u.Position == 2) {
                lbHello.Text = "Xin chào Nhân viên Bán hàng";
            }
            else if (u.Position == 3)
            {
                lbHello.Text = "Xin chào Nhân viên Kho";
            }
            btnProfile.Text = u.Name;
            if (!u.Image_link.Equals("")) {
                btnProfile.Iconimage = Image.FromFile(u.Image_link);
            }
            
        }

        
        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Value == true)
            {
                panel1.BackColor = Color.FromArgb(17, 17, 17);
                btnAccount.Normalcolor = Color.FromArgb(17, 17, 17);
                btnBC.Normalcolor = Color.FromArgb(17, 17, 17);
                btnDM.Normalcolor = Color.FromArgb(17, 17, 17);
                btnQLBH.Normalcolor = Color.FromArgb(17, 17, 17);
                btnSP.Normalcolor = Color.FromArgb(17, 17, 17);
                btnTK.Normalcolor = Color.FromArgb(17, 17, 17);
                panel2.BackColor = Color.FromArgb(17, 17, 17);
                btnRules.Normalcolor = Color.FromArgb(17, 17, 17);
                btnInform.Normalcolor = Color.FromArgb(17, 17, 17);
                btnKHang.Normalcolor = Color.FromArgb(17, 17, 17);
            }
            else
            {
                panel1.BackColor = Color.FromArgb(42, 201, 173);
                btnAccount.Normalcolor = Color.FromArgb(42, 201, 173);
                btnBC.Normalcolor = Color.FromArgb(42, 201, 173);
                btnDM.Normalcolor = Color.FromArgb(42, 201, 173);
                btnQLBH.Normalcolor = Color.FromArgb(42, 201, 173);
                btnSP.Normalcolor = Color.FromArgb(42, 201, 173);
                btnTK.Normalcolor = Color.FromArgb(42, 201, 173);
                panel2.BackColor = Color.FromArgb(42, 201, 173);
                btnRules.Normalcolor = Color.FromArgb(42, 201, 173);
                btnInform.Normalcolor = Color.FromArgb(42, 201, 173);
                btnKHang.Normalcolor = Color.FromArgb(42, 201, 173);
            }

        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            initButtonClick();
            if (bunifuiOSSwitch1.Value == true)
            {
                btnTK.Normalcolor = Color.FromArgb(255, 192, 128);
            }
            else
            {
                btnTK.Normalcolor = Color.DimGray;
            }
            statisticalFragment1.LoadData(DateTime.Now);
            statisticalFragment1.BringToFront();
        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            initButtonClick();
            if (bunifuiOSSwitch1.Value == true)
            {
                btnBC.Normalcolor = Color.FromArgb(255, 192, 128);
            }
            else
            {
                btnBC.Normalcolor = Color.DimGray;
            }
            reportFragment1.LoadData();
            reportFragment1.BringToFront();
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            initButtonClick();
            if (bunifuiOSSwitch1.Value == true)
            {
                btnSP.Normalcolor = Color.FromArgb(255, 192, 128);
            }
            else
            {
                btnSP.Normalcolor = Color.DimGray;
            }
            productFragment1.LoadCatalog();
            productFragment1.LoadListProduct();
            productFragment1.BringToFront();
        }

        private void btnDM_Click(object sender, EventArgs e)
        {
            initButtonClick();
            if (bunifuiOSSwitch1.Value == true)
            {
                btnDM.Normalcolor = Color.FromArgb(255, 192, 128);
            }
            else
            {
                btnDM.Normalcolor = Color.DimGray;
            }
            categoryFragment1.LoadListCatalog();
            categoryFragment1.BringToFront();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            initButtonClick();
            if (bunifuiOSSwitch1.Value == true)
            {
                btnAccount.Normalcolor = Color.FromArgb(255, 192, 128);
            }
            else
            {
                btnAccount.Normalcolor = Color.DimGray;
            }
            accountFragment1.LoadData();
            accountFragment1.BringToFront();
        }


        private void btnQLBH_Click(object sender, EventArgs e)
        {
            initButtonClick();
            if (bunifuiOSSwitch1.Value == true)
            {
                btnQLBH.Normalcolor = Color.FromArgb(255, 192, 128);
            }
            else
            {
                btnQLBH.Normalcolor = Color.DimGray;
            }
            salesManagerFragment1.LoadListTransaction();
            salesManagerFragment1.LoadTotalTransaction();
            salesManagerFragment1.BringToFront();
        }


        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Common1.Id = 0;
                Common1.postionPermistion = 0;
                this.Close();
            }
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            initButtonClick();
            if (bunifuiOSSwitch1.Value == true)
            {
                btnKHang.Normalcolor = Color.FromArgb(255, 192, 128);
            }
            else
            {
                btnKHang.Normalcolor = Color.DimGray;
            }
            customerFragment1.LoadData();
            customerFragment1.BringToFront();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            initButtonClick();
            if (bunifuiOSSwitch1.Value == true)
            {
                btnRules.Normalcolor = Color.FromArgb(255, 192, 128);
            }
            else
            {
                btnRules.Normalcolor = Color.DimGray;
            }
            rulesFragment1.LoadData();
            rulesFragment1.BringToFront();

        }

        public void initButtonClick()
        {
            if (bunifuiOSSwitch1.Value == true)
            {
                panel1.BackColor = Color.FromArgb(17, 17, 17);
                btnAccount.Normalcolor = Color.FromArgb(17, 17, 17);
                btnBC.Normalcolor = Color.FromArgb(17, 17, 17);
                btnDM.Normalcolor = Color.FromArgb(17, 17, 17);
                btnQLBH.Normalcolor = Color.FromArgb(17, 17, 17);
                btnSP.Normalcolor = Color.FromArgb(17, 17, 17);
                btnTK.Normalcolor = Color.FromArgb(17, 17, 17);
                btnRules.Normalcolor = Color.FromArgb(17, 17, 17);
                btnInform.Normalcolor = Color.FromArgb(17, 17, 17);
                btnKHang.Normalcolor = Color.FromArgb(17, 17, 17);
                panel2.BackColor = Color.FromArgb(17, 17, 17);
            }
            else
            {
                panel1.BackColor = Color.FromArgb(42, 201, 173);
                btnAccount.Normalcolor = Color.FromArgb(42, 201, 173);
                btnBC.Normalcolor = Color.FromArgb(42, 201, 173);
                btnDM.Normalcolor = Color.FromArgb(42, 201, 173);
                btnQLBH.Normalcolor = Color.FromArgb(42, 201, 173);
                btnSP.Normalcolor = Color.FromArgb(42, 201, 173);
                btnTK.Normalcolor = Color.FromArgb(42, 201, 173);
                btnRules.Normalcolor = Color.FromArgb(42, 201, 173);
                btnInform.Normalcolor = Color.FromArgb(42, 201, 173);
                btnKHang.Normalcolor = Color.FromArgb(42, 201, 173);
                panel2.BackColor = Color.FromArgb(42, 201, 173);
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            using (Utils.ControlBoxFunction drop = new Utils.ControlBoxFunction())
            {
                drop.StartPosition = FormStartPosition.Manual;
                drop.Location = new System.Drawing.Point(920, 85);
                drop.ShowDialog();
                drop.Close();
            }
        }

        private void btnInform_Click(object sender, EventArgs e)
        {
            initButtonClick();
            if (bunifuiOSSwitch1.Value == true)
            {
                btnInform.Normalcolor = Color.FromArgb(255, 192, 128);
            }
            else
            {
                btnInform.Normalcolor = Color.DimGray;
            }
            infoFragment1.LoadData();
            infoFragment1.BringToFront();
        }
    }
}
