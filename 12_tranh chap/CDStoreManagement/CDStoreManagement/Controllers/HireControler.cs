using CDStoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Controllers
{
    public class HireControler
    {
        HireControler() { }
        private static HireControler instance;
        public static HireControler Instance
        {
            get { if (instance == null) instance = new HireControler(); return instance; }
            private set { instance = value; }
        }

        public void InsertHire(int id_transactiona, double deposit, double total, double discount)
        {
            string query = "EXECUTE dbo.INSERT_HIRE @ID_TRANSACTION = "+id_transactiona+" , @DEPOSIT = "+deposit+" , @TOTAL = "+total+" , @DISCOUNT = "+discount+"";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void DeleteHire(int idTransaction)
        {
            string query = "EXECUTE dbo.DELETE_HIRE @ID_TRANSACTION = "+ idTransaction;
            DataProvider.Instance.ExecuteQuery(query);
        }

        public Hire GetHireByIdTransa(int id) {
            string query = "SELECT * FROM dbo.GET_HIRE_BY_IDTRAN("+id+")";
            return new Hire(DataProvider.Instance.ExecuteQuery(query).Rows[0]);

        }
        public void UpdateHire(int idTran,double damage , double expired, double totalPrice) {
            string query = "EXECUTE dbo.UPDATE_HIRE @ID_TRAN = "+idTran+" , @DAMAGE = "+damage+" , @EXPIRED = "+expired+" , @TOTALPRICE = "+totalPrice+"";
            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
