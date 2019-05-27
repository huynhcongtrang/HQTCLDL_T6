using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Models
{
    public class Catalog
    {
        private int id;
        private string name;
        public Catalog(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
        }
        public Catalog() { }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
