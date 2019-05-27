using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Common
{
    public class ItemReview
    {

        private int idProduct;
        private int totalProduct;
        private int totalDamage;
        private double price; 
        public ItemReview(int idProduct, int totalProduct, int totalDamage,double price)
        {
            this.IdProduct = idProduct;
            this.TotalProduct = totalProduct;
            this.TotalDamage = totalDamage;
            this.Price = price;
        }
        public int IdProduct { get => idProduct; set => idProduct = value; }
        public int TotalProduct { get => totalProduct; set => totalProduct = value; }
        public int TotalDamage { get => totalDamage; set => totalDamage = value; }
        public double Price { get => price; set => price = value; }
    }
}
