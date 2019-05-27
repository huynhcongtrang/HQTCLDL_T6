using CDStoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Controllers
{
    public class InFoCompanyControler
    {
        InFoCompanyControler() { }
        private static InFoCompanyControler instance;
        public static InFoCompanyControler Instance
        {
            get { if (instance == null) instance = new InFoCompanyControler(); return instance; }
            private set { instance = value; }
        }


        public Info_store GetInfoStore()
        {
            string query = "select * from Info_store";
            return new Info_store(DataProvider.Instance.ExecuteQuery(query).Rows[0]);
        }
        public void UpdateInfoStore(string email,string address,string phone) {
            string query = "EXECUTE dbo.UPDATE_INFOSTORE @EMAIL = '"+email+"',@ADDRESS = N'"+address+"',@PHONE = '"+phone+"'";
            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
