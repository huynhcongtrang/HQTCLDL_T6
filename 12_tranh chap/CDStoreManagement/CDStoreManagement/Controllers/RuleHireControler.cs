using CDStoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Controllers
{
    public class RuleHireControler
    {
        private static RuleHireControler instance;
        public static RuleHireControler Instance
        {
            get { if (instance == null) instance = new RuleHireControler(); return instance; }
            private set { instance = value; }
        }
        public Rule_hire GetRuleHire(int id)
        {
            string query = "EXECUTE dbo.GET_RULE_HIRE @ID = " + id;
            Rule_hire rule_hire = new Rule_hire(DataProvider.Instance.ExecuteQuery(query).Rows[0]);
            return rule_hire;
        }

        public void UpdateRuleHire(int id, int percentHire, int percentDeposit, int numberDatePay, int percentFine, int totalDiscount, int percentDiscount)
        {
            string query = "EXECUTE dbo.UPDATE_RULEHIRE @ID = "+id+", @PERCENTHIRE = "+percentHire+", @PERCENTDEPOSIT = "+percentDeposit+", @NUMBEDATEPAY = "+numberDatePay+", @PERCENTFINE = "+percentFine+", @TOTALDISCOUNT = "+totalDiscount+", @PERCENTDISCOUNT = "+percentDiscount+"";
            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
