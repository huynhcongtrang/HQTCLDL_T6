using CDStoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Controllers
{
    public class TransactionDetailControler
    {
        TransactionDetailControler() { }
        private static TransactionDetailControler instance;
        public static TransactionDetailControler Instance
        {
            get { if (instance == null) instance = new TransactionDetailControler(); return instance; }
            private set { instance = value; }
        }

       

        public void InsertTransactionDetail(int id_transaction, int id_product, int total_product, double price)
        {
            string query = "EXECUTE dbo.INSERT_TRANSACTION_DETAIL @ID_TRANSACTION = "+id_transaction+", @ID_PRODUCT = "+id_product+", @TOTAL_PRODUCT = "+total_product+",  @PRICE = "+price+"";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public void DeleteTransactionDetail(int idTransaction) {
            string query = "EXECUTE dbo.DELETE_TRANSACTION_DETAIL @ID_TRANSACTION = " + idTransaction;
            DataProvider.Instance.ExecuteQuery(query);
        }

        public List<TransactionaDetail> GetListTransactionDetailById(int idTran)
        {
            List<TransactionaDetail> list = new List<TransactionaDetail>();
            string query = "EXECUTE dbo.GET_LIST_TRANSACTION_DETAIL @ID_TRAN = " + idTran;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TransactionaDetail tranDe = new TransactionaDetail(item);
                list.Add(tranDe);
            }
            return list;
        }

      

        public TransactionaDetail GetTranSacDeByIdProAndIdTran(int idPro, int idTran) {
            string query = "SELECT * FROM dbo.GET_TRANSACTION_BUY_IDTRAN_PRO("+idPro+","+idTran+")";
            TransactionaDetail tranDe = new TransactionaDetail(DataProvider.Instance.ExecuteQuery(query).Rows[0]);
            return tranDe;
        }

        public void UpdateTotalDetailTransaction(int idTran, int idPro , int total) {
            string query = "EXECUTE dbo.UPDATE_TOTAL_TRANSACTIONDETAIL @ID_TRAN = "+idTran+", @ID_PRO = "+idPro+", @TOTAL = "+total+"";
            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
