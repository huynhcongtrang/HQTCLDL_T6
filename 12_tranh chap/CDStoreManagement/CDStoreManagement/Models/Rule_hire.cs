using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Models
{
    public class Rule_hire
    {
        private int id;
        private int percent_hire;
        private int percent_deposit;
        private int number_date_pay;
        private int percent_fine;
        private int total_discount;
        private int percent_discount;

        public Rule_hire(DataRow row) {
            this.Id = (int)row["id"];
            this.Percent_hire = Convert.ToInt32(row["percent_hire"]);
            this.Percent_deposit = Convert.ToInt32(row["percent_deposit"]);
            this.Number_date_pay = Convert.ToInt32(row["number_date_pay"]);
            this.Percent_fine = Convert.ToInt32(row["percent_fine"]);
            this.Total_discount = Convert.ToInt32(row["total_discount"]);
            this.Percent_discount = Convert.ToInt32(row["percent_discount"]);
        }
        public int Id { get => id; set => id = value; }
        public int Percent_hire { get => percent_hire; set => percent_hire = value; }
        public int Percent_deposit { get => percent_deposit; set => percent_deposit = value; }
        public int Number_date_pay { get => number_date_pay; set => number_date_pay = value; }
        public int Percent_fine { get => percent_fine; set => percent_fine = value; }
        public int Total_discount { get => total_discount; set => total_discount = value; }
        public int Percent_discount { get => percent_discount; set => percent_discount = value; }
    }
}
