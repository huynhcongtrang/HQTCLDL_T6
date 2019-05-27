using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Models
{
    public class Product
    {
        private int id;
        private int idCatalog;
        private string typeDisk;
        private string name;
        private string namePerfor;
        private double price;
        private string content;
        private double discount;
        private string image;
        private int total;
        private int totalHire;
        private int totalBuy;
        private DateTime created;


        public Product(DataRow row)
        {
            this.Id = (int)row["id"];
            this.IdCatalog = (int)row["id_catalog"];
            this.TypeDisk = row["type_disk"].ToString();
            this.Name = row["name"].ToString();
            this.NamePerfor = row["name_perfor"].ToString();
            this.Price = (Double)Convert.ToDouble(row["price"].ToString());
            this.Content = row["content"].ToString();
            this.Discount = (Double)Convert.ToDouble(row["discount"].ToString());
            this.Image = row["image"].ToString();
            this.Total = (int)row["total"];
            this.TotalHire = (int)row["total_hire"];
            this.TotalBuy = (int)row["total_buy"];
            this.Created = (DateTime)row["created"];
        }

        public int IdCatalog { get => idCatalog; set => idCatalog = value; }
        public string TypeDisk { get => typeDisk; set => typeDisk = value; }
        public string Name { get => name; set => name = value; }
        public string NamePerfor { get => namePerfor; set => namePerfor = value; }
        public double Price { get => price; set => price = value; }
        public string Content { get => content; set => content = value; }
        public double Discount { get => discount; set => discount = value; }
        public string Image { get => image; set => image = value; }
        public int Total { get => total; set => total = value; }
        public int TotalHire { get => totalHire; set => totalHire = value; }
        public int TotalBuy { get => totalBuy; set => totalBuy = value; }
        public DateTime Created { get => created; set => created = value; }
        public int Id { get => id; set => id = value; }
    }
}
