using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Models
{
    public class Hire
    {
        private int id;
        private int id_transaction;
        private double damage;
        private double expired;
        private double deposit;
        private double total;
        private double discount;

        public Hire(DataRow row) {
            this.Id = (int)row["id"];
            this.Id_transaction = (int)row["id_transactiona"];
            this.Damage = (Double)Convert.ToDouble(row["damage"].ToString());
            this.Expired = (Double)Convert.ToDouble(row["expired"].ToString());
            this.Deposit = (Double)Convert.ToDouble(row["deposit"].ToString());
            this.Total = (Double)Convert.ToDouble(row["total"].ToString());
            this.Discount = (Double)Convert.ToDouble(row["discount"].ToString());
        }

        public int Id { get => id; set => id = value; }
        public int Id_transaction { get => id_transaction; set => id_transaction = value; }
        public double Damage { get => damage; set => damage = value; }
        public double Expired { get => expired; set => expired = value; }
        public double Deposit { get => deposit; set => deposit = value; }
        public double Total { get => total; set => total = value; }
        public double Discount { get => discount; set => discount = value; }
    }
}
