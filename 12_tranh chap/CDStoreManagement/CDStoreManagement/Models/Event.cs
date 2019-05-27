using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Models
{
    public class Event
    {
        private int id;
        private string title;
        private DateTime datebegin;
        private DateTime dateend;
        private int percentDiscount;

        public Event(DataRow row) {
            this.Id = (int)row["id"];
            this.title = row["title"].ToString();
            this.Datebegin = (DateTime)row["datebegin"];
            this.Dateend = (DateTime)row["dateend"];
            this.PercentDiscount = (int)row["percent_discount"];
        }

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public DateTime Datebegin { get => datebegin; set => datebegin = value; }
        public DateTime Dateend { get => dateend; set => dateend = value; }
        public int PercentDiscount { get => percentDiscount; set => percentDiscount = value; }
    }
}
