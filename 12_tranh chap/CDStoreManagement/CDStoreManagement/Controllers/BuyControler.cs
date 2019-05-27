using CDStoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Controllers
{
    public class BuyControler
    {
        BuyControler() { }
        private static BuyControler instance;
        public static BuyControler Instance
        {
            get { if (instance == null) instance = new BuyControler(); return instance; }
            private set { instance = value; }
        }

        public void InsertBuy(int id_transactiona, double total, double discount) {
            string query = "EXECUTE dbo.INSERT_BUY @ID_TRANSACTION = "+id_transactiona+" , @TOTAL = "+total+" , @DISCOUNT = "+discount+"";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public void DeleteBuy(int idTransaction) {
            string query = "EXECUTE dbo.DELETE_BUY @IDTRANSACTION = "+ idTransaction;
            DataProvider.Instance.ExecuteQuery(query);
        }

        public Buy GetBuyByIdTransa(int id)
        {
            string query = "SELECT * FROM  GET_BUY_BYIDTRANSACTION("+id+")";
            return new Buy(DataProvider.Instance.ExecuteQuery(query).Rows[0]);

        }

        public void UpdateTotalBuyTran(int id, double total)
        {
            string query = "EXECUTE dbo.UPDATE_TOTAL_BUYTRAN @ID = "+id+" , @TOTAL = " + total;
            DataProvider.Instance.ExecuteQuery(query);

        }
    }
}
