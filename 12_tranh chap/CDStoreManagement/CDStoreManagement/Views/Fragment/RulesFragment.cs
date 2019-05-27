using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDStoreManagement.Utils.RulesFunction;
using CDStoreManagement.Models;
using CDStoreManagement.Controllers;
using CDStoreManagement.Common;

namespace CDStoreManagement.Views.Fragment
{
    public partial class RulesFragment : UserControl
    {
        public RulesFragment()
        {
            InitializeComponent();
            if (Common1.postionPermistion == Common1.positionNhanVien) {
                bunifuFlatButton1.Visible = false;
                btnReset.Visible = false;
            }
        }

        #region method
        void LoadBuy() {
            Rule_buy ruleBuy = RuleBuyControler.Instance.GetRuleBuy(Common1.idRuleBuy);
            // buy
            lbTotalDiscountBuy.Text = ruleBuy.Total_discount.ToString();
            lbPercentDiscountBuy.Text = ruleBuy.Percent_discount.ToString();
            lbDateChange.Text = ruleBuy.Number_date_change.ToString();
        }
        void LoadHire() {
            Rule_hire ruleHire = RuleHireControler.Instance.GetRuleHire(Common1.idRuleHire);

            // hire
            lbPercentHire.Text = ruleHire.Percent_hire.ToString();
            lnPercentDesipo.Text = ruleHire.Percent_deposit.ToString();
            lbTotalPay.Text = ruleHire.Number_date_pay.ToString();
            lnPercentFineExpired.Text = ruleHire.Percent_fine.ToString();
            lbTotalDiscountHire.Text = ruleHire.Total_discount.ToString();
            lbPercentDiscoutHire.Text = ruleHire.Percent_discount.ToString();
        }
        public void LoadData() {
            LoadBuy();
            LoadHire();
        }
        #endregion


        #region event

        private void btnReset_Click(object sender, EventArgs e)
        {
            using (RuleBuyFunction ruleBuy = new RuleBuyFunction())
            {
                ruleBuy.ShowDetailRuleBuy();
                ruleBuy.ShowDialog();
            }
            LoadBuy();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            using (RuleHireFunction ruleHire = new RuleHireFunction())
            {
                ruleHire.ShowDetailRuleHire();
                ruleHire.ShowDialog();
            }
            LoadHire();
        }
        #endregion
    }
}
