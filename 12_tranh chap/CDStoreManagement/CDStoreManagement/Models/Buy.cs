using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Models
{
    public class Buy
    {
        private int id;
        private int id_transaction;
        private double total;
        private double discount;

        
        public Buy(DataRow row) {
            this.Id = (int)row["id"];
            this.Id_transaction = (int)row["id_transactiona"];
            this.Total = (Double)Convert.ToDouble(row["total"].ToString());
            this.Discount = (Double)Convert.ToDouble(row["discount"].ToString());
        }
        public int Id_transaction { get => id_transaction; set => id_transaction = value; }
        public double Total { get => total; set => total = value; }
        public double Discount { get => discount; set => discount = value; }
        public int Id { get => id; set => id = value; }
    }
}
