using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Models
{
    public class Customer
    {
        private int id;

        private string name;

        private string phone;
        private string address;
        private DateTime created;


        public Customer(DataRow row)
        {
            this.id = (int)row["id"];
            this.name = row["name"].ToString();
            this.phone = row["phone"].ToString();
            this.address = row["address"].ToString();
            this.created = (DateTime)row["created"];
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public DateTime Created { get => created; set => created = value; }
    }
}
