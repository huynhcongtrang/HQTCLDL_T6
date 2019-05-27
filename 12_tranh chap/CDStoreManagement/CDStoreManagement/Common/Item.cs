using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Common
{
    public class Item
    {
        private int idProduct;
        private int totalProduct;
        public Item(int idProduct, int totalProduct) {
            this.IdProduct = idProduct;
            this.TotalProduct = totalProduct;
        }
        public int IdProduct { get => idProduct; set => idProduct = value; }
        public int TotalProduct { get => totalProduct; set => totalProduct = value; }
    }
}
