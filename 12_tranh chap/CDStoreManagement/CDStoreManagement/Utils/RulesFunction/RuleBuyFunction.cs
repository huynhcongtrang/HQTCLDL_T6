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

namespace CDStoreManagement.Utils.RulesFunction
{
    public partial class RuleBuyFunction : Form
    {
        public RuleBuyFunction()
        {
            InitializeComponent();
        }
        public void ShowDetailRuleBuy() {
            Rule_buy ruleBuy = RuleBuyControler.Instance.GetRuleBuy(Common1.idRuleBuy);
            txtTotalDiscount.Text = ruleBuy.Total_discount.ToString();
            txtPercentDiscount.Text = ruleBuy.Percent_discount.ToString();
            txtDateChange.Text = ruleBuy.Number_date_change.ToString();
        }
        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool CheckNumber(string number) {
            int n;
            if (int.TryParse(number, out n) && n > 0 ) {
                return true;
            }
            return false;
        }
        bool CheckNumberPercent(string number)
        {
            int n;
            if (int.TryParse(number, out n) && n > 0 && n < 101)
            {
                return true;
            }
            return false;
        }
        private void btnUpdateBuy_Click(object sender, EventArgs e)
        {
            string totalDiscount = txtTotalDiscount.Text;
            string percentDiscount = txtPercentDiscount.Text;
            string dateChange = txtDateChange.Text;
            if (!CheckNumber(totalDiscount)) {
                MessageBox.Show("Kiểm tra lại số lượng giảm giá !");
                return;
            }
            if (!CheckNumber(dateChange)) {
                MessageBox.Show("Kiểm tra lại số ngày đổi trả !");
                return;
            }
            if (!CheckNumberPercent(percentDiscount))
            {
                MessageBox.Show("Kiểm tra lại phần trăm giảm giá !");
                return;
            }

            RuleBuyControler.Instance.UpdateRuleBuy(Common1.idRuleBuy, Convert.ToInt32(percentDiscount), Convert.ToInt32(totalDiscount), Convert.ToInt32(dateChange));
            MessageBox.Show("Thành công !");
            this.Close();
        }
    }
}
