using CDStoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Controllers
{
    public class RuleBuyControler
    {
        private static RuleBuyControler instance;
        public static RuleBuyControler Instance
        {
            get { if (instance == null) instance = new RuleBuyControler(); return instance; }
            private set { instance = value; }
        }
        public Rule_buy GetRuleBuy(int id)
        {
            string query = "EXECUTE dbo.GET_RULE_BUY @ID = "+ id;
            Rule_buy rule_buy = new Rule_buy(DataProvider.Instance.ExecuteQuery(query).Rows[0]);
            return rule_buy;
        }

        public void UpdateRuleBuy(int id,int percentDiscount , int totalDiscount , int numberDateChange) {
            string query = "EXECUTE dbo.UPDATE_RULEBUY @ID = "+id+", @PERCENTDISCOUNT = "+percentDiscount+", @TOTALDISCOUNT = "+totalDiscount+", @NUMBERDATECHANGE = "+numberDateChange+"";
            DataProvider.Instance.ExecuteQuery(query);
        }

    }
}
