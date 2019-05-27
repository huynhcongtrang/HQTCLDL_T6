using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Models
{
    public class Rule_buy
    {
        private int id;
        private int percent_discount;
        private int total_discount;
        private int number_date_change;

        public Rule_buy(DataRow row) {
            this.Id = (int)row["id"];
            this.Percent_discount = Convert.ToInt32(row["percent_discount"]);
            this.Total_discount = Convert.ToInt32(row["total_discount"]);
            this.Number_date_change = Convert.ToInt32(row["number_date_change"]);
        }

        public int Id { get => id; set => id = value; }
        public int Percent_discount { get => percent_discount; set => percent_discount = value; }
        public int Total_discount { get => total_discount; set => total_discount = value; }
        public int Number_date_change { get => number_date_change; set => number_date_change = value; }
    }
}
