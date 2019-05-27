using CDStoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Controllers
{
    public class TransactionControler
    {
        private static TransactionControler instance;
        public static TransactionControler Instance
        {
            get { if (instance == null) instance = new TransactionControler(); return instance; }
            private set { instance = value; }
        }

        public List<Transaction> GetListTransaction()
        {
            List<Transaction> list = new List<Transaction>();
            string query = "select * from Transactiona";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Transaction transaction = new Transaction(item);
                list.Add(transaction);
            }
            return list;
        }

        public int GetTotal(int type)
        {
            string query = "EXECUTE dbo.GET_TOTAL @TYPE = "+ type;
            return DataProvider.Instance.ExecuteQuery(query).Rows.Count;
        }
        public DataTable GetListTransactionWhere(string queryExtend)
        {
            string query = "select a.id as N'Mã',b.name as 'Tên khách hàng',b.phone as N'Số điện thoại',CASE a.type WHEN 1 THEN N'Mua đĩa' WHEN 2 THEN N'Thuê đĩa' WHEN 3 THEN N'Đã trả' END as N'Trạng thái',CONVERT(VARCHAR(10), a.created, 105) as N'Ngày tạo' from Transactiona a, Customer b where a.id_customer = b.id " + queryExtend;
            return DataProvider.Instance.ExecuteQuery(query);
        }
      

        public void InsertTransaction(int id_customer, int id_user, int type, DateTime created)
        {
            string query = "EXECUTE dbo.INSERT_TRANSACTION @ID_CUSTOMER = "+id_customer+", @ID_USER = "+id_user+", @TYPE = "+type+", @CREATED = '"+created+"'";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public Transaction GetTransactionById(int idTransaction) {
            string query = "EXECUTE dbo.GET_TRANSACTION_BUY_ID @IDTRANSACTION = "+ idTransaction;
            Transaction tran = new Transaction(DataProvider.Instance.ExecuteQuery(query).Rows[0]);
            return tran;
        }
        public int ReturnIdRecent()
        {
            string query = "SELECT dbo.GETIDRECENT()";
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));

        }

        public void DeleteTransaction(int id) {
            string query = "EXECUTE dbo.DETELE_TRANSACTION @ID = " + id;
            DataProvider.Instance.ExecuteQuery(query);
        }
        public void UpdateTypeByIdTran(int idTran, int type) {
            string query = "EXECUTE dbo.UPDATE_TYPE_TRANSACTION @IDTRAN = "+idTran+", @TYPE = "+type+"";
            DataProvider.Instance.ExecuteQuery(query);
        }

        // khach hang
        public bool CheckExitUserIntoTran(int idUser)
        {
            string query = "EXECUTE dbo.CHECK_EXITS_USER_INTRAN @ID_USER = "+idUser;

            return Convert.ToBoolean(DataProvider.Instance.ExecuteQuery(query).Rows[0][0]); 
        }
    }
}
