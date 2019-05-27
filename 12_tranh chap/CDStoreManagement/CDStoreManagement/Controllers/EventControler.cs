using CDStoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Controllers
{
    public class EventControler
    {
        EventControler() { }
        private static EventControler instance;
        public static EventControler Instance
        {
            get { if (instance == null) instance = new EventControler(); return instance; }
            private set { instance = value; }
        }

        public List<Event> GetListEvent()
        {
            List<Event> list = new List<Event>();
            string query = "SELECT * FROM dbo.GET_LIST_EVENT()";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Event ev = new Event(item);
                list.Add(ev);
            }
            return list;
        }

        public void AddEvent(string title , string datebegin , string dateend, int discount) {
            string query = "EXECUTE dbo.INSERT_EVENT @ID_INFO = 1 , @TITLE = N'"+title+"' , @DATEBEGIN = N'"+datebegin+"' , @DATEEND = N'"+dateend+"' ,  @DISCOUNT = "+discount;
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void RemoveEvent()
        {
            string query = "EXECUTE dbo.REMOVE_EVENT";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public List<Event> GetListEventByDate()
        {
            List<Event> list = new List<Event>();
            string query = "SELECT * FROM dbo.GETLISTEVENTBYDATE()";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Event ev = new Event(item);
                list.Add(ev);
            }
            return list;
        }

        public List<Event> GetListEventByDate(string date)
        {
            List<Event> list = new List<Event>();
            string query = "SELECT * FROM dbo.GETLISTEVENTBYDATE2('"+date+"')";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Event ev = new Event(item);
                list.Add(ev);
            }
            return list;
        }
    }
}
