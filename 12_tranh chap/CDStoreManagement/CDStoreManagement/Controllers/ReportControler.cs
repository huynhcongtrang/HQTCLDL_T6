using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Controllers
{
    class ReportControler
    {
        private static ReportControler instance;

        public static ReportControler Instance
        {
            get { if (instance == null) instance = new ReportControler(); return instance; }
            set { instance = value; }
        }

        private ReportControler()
        {

        }
        public DataTable getReportBuy() {
            string query = "SELECT * FROM dbo.GET_REPORT_BUY()";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable getReportHire()
        {
            string query = "SELECT * FROM dbo.GET_REPORT_HIRE()";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable getReportBuyDay(int day, int month, int year)
        {
            string query = "SELECT * FROM dbo.GET_REPORT_BUY_DATE(" + day+","+month+","+year+")";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        

        public DataTable getReportBuyMonth(int month, int year)
        {
            string query = "SELECT * FROM dbo.GET_REPORT_BUY_MONTH("+month+","+year+")";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable getReportHireDay(int day, int month, int year)
        {
            string query = "SELECT * FROM dbo.GET_REPORT_HIRE_DATE(" + day + "," + month + "," + year + ")";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable getReportHireMonth(int month, int year)
        {
            string query = "SELECT * FROM dbo.GET_REPORT_HIRE_MONTH(" + month + "," + year + ")";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable getTotalBuy(int day, int month, int year)
        {
            string query = "EXECUTE dbo.GET_TOTAL_BUY @DAY = " + day + ", @MONTH = " + month + ", @YEAR = " + year + "";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable getTotalBuy() {
            string query = "SELECT * FROM dbo.GET_TOTAL_BUY2()";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable getTotalHire()
        {
            string query = "SELECT * FROM dbo.GET_TOTAL_HIRE2()";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable getTotalHire(int day, int month, int year)
        {
            string query = "EXECUTE dbo.GET_TOTAL_HIRE @DAY = "+day+", @MONTH = "+month+", @YEAR = "+year+"";
            return DataProvider.Instance.ExecuteQuery(query);
            
        }
    }
}
