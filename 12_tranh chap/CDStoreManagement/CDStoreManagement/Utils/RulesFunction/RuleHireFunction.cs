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
    public partial class RuleHireFunction : Form
    {
        public RuleHireFunction()
        {
            InitializeComponent();
        }

        public void ShowDetailRuleHire() {
            Rule_hire ruleHire = RuleHireControler.Instance.GetRuleHire(Common1.idRuleHire);
            txtPercentHire.Text = ruleHire.Percent_hire.ToString();
            txtPercentDisposit.Text = ruleHire.Percent_deposit.ToString();
            txtDatePay.Text = ruleHire.Number_date_pay.ToString();
            txtFineExpired.Text = ruleHire.Percent_fine.ToString();
            txtTotalDiscount.Text = ruleHire.Total_discount.ToString();
            txtPercentDiscount.Text = ruleHire.Percent_discount.ToString();
        }
        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool CheckNumber(string number)
        {
            int n;
            if (int.TryParse(number, out n) && n > 0)
            {
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string percentHire = txtPercentHire.Text;
            string percentDeposit = txtPercentDisposit.Text;
            string datePay = txtDatePay.Text;
            string fineExpired = txtFineExpired.Text;
            string totalDiscount = txtTotalDiscount.Text;
            string percentDiscount = txtPercentDiscount.Text;

            if (!CheckNumberPercent(percentHire)) {
                MessageBox.Show("Kiểm tra lại phần trăm thuê !");
                return;
            }

            if (!CheckNumberPercent(percentDeposit))
            {
                MessageBox.Show("Kiểm tra lại phần trăm đặt cọc !");
                return;
            }

            if (!CheckNumber(datePay))
            {
                MessageBox.Show("Kiểm tra lại số ngày trả !");
                return;
            }

            if (!CheckNumberPercent(fineExpired))
            {
                MessageBox.Show("Kiểm tra lại phần trăm phạt quá hạng !");
                return;
            }

            if (!CheckNumber(totalDiscount))
            {
                MessageBox.Show("Kiểm tra lại số lượng giảm giá !");
                return;
            }

            if (!CheckNumberPercent(percentDiscount))
            {
                MessageBox.Show("Kiểm tra lại phần trăm giảm giá!");
                return;
            }

            RuleHireControler.Instance.UpdateRuleHire(Common1.idRuleHire,Convert.ToInt32(percentHire), Convert.ToInt32(percentDeposit), Convert.ToInt32(datePay), Convert.ToInt32(fineExpired), Convert.ToInt32(totalDiscount), Convert.ToInt32(percentDiscount));
            MessageBox.Show("Thành công !");
            this.Close();
        }
    }
}
