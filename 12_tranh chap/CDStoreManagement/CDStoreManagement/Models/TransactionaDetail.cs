using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Models
{
    public class TransactionaDetail
    {
        private int id_transaction ;
        private int id_product;
        private int total_product;
        private double price;

        public TransactionaDetail(DataRow row)
        {
            this.Id_transaction = (int)row["id_transactiona"];
            this.Id_product = (int)row["id_product"];
            this.Total_product = (int)row["total_product"];
            this.Price = (Double)Convert.ToDouble(row["price"].ToString());
        }

        public int Id_transaction { get => id_transaction; set => id_transaction = value; }
        public int Id_product { get => id_product; set => id_product = value; }
        public int Total_product { get => total_product; set => total_product = value; }
        public double Price { get => price; set => price = value; }
    }
}
