using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Controllers
{
    class StaticticalControler
    {

        private static StaticticalControler instance;

        public static StaticticalControler Instance
        {
            get { if (instance == null) instance = new StaticticalControler(); return instance; }
            set { instance = value; }
        }

        public double getDataStatisticalByDayMonthYear(string fillDate)
        {
            string query = "select sum(total) from Transactiona a , Buy b where a.id = b.id_transactiona " + fillDate;
            string query2 = "select sum(total) from Transactiona a , Hire b where a.id = b.id_transactiona and a.type = 3 " + fillDate;
            string query3 = "select sum(total - discount) from Transactiona a , Hire b  where a.id = b.id_transactiona and a.type = 2 " + fillDate;
            double resultMain = 0;
            string result = DataProvider.Instance.ExecuteQuery(query).Rows[0][0].ToString();
            if (!result.Equals("")) {
                resultMain += Convert.ToDouble(result);
            }
            result = DataProvider.Instance.ExecuteQuery(query2).Rows[0][0].ToString();
            if (!result.Equals(""))
            {
                resultMain += Convert.ToDouble(result);
            }
            result = DataProvider.Instance.ExecuteQuery(query3).Rows[0][0].ToString();
            if (!result.Equals(""))
            {
                resultMain += Convert.ToDouble(result);
            }
            return resultMain;
        }

        public double GetDamage(string fillDate) {
            string query = "select sum(damage) from Transactiona a , Hire b  where a.id = b.id_transactiona and a.type = 3 " + fillDate;
            string result = DataProvider.Instance.ExecuteQuery(query).Rows[0][0].ToString();
            if (result.Equals(""))
            {
                return 0;
                
            }
            return Convert.ToDouble(result);
        }
        
        public DataTable getDataEveryMonth(int year)
        {
            string query = "SELECT * FROM dbo.GET_DATA_EVERY_MONTH("+year+")";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable getMostpurchasedproducts(int year)
        {
            string query = "SELECT * FROM dbo.GET_MOST_PURCHARE_PRODUCT("+year+")";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable getTotalProduct(int year)
        {
            string query = "SELECT * FROM dbo.GET_TOTAL_PRODUCT("+year+")";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable getNerestYear(int year)
        {
            string query = "SELECT * FROM dbo.GET_NEREST_YEAR("+year+")";
            return DataProvider.Instance.ExecuteQuery(query);
        }


    }
}
