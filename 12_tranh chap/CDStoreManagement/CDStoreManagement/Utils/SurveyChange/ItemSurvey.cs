using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Utils.SurveyChange
{
    public class ItemSurvey
    {
        private int id_Product;
        private int total_Product;
        private int total_Change;
        private double price;
        ItemSurvey() { }

        public ItemSurvey(int idPro , int totalPro ,int totalChange, double price) {
            this.Id_Product = idPro;
            this.Total_Product = totalPro;
            this.Total_Change = totalChange;
            this.Price = price;
        }

        public int Id_Product { get => id_Product; set => id_Product = value; }
        public int Total_Product { get => total_Product; set => total_Product = value; }
        public double Price { get => price; set => price = value; }
        public int Total_Change { get => total_Change; set => total_Change = value; }
    }
}
