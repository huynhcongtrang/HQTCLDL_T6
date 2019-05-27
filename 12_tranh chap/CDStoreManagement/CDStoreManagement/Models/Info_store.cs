using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Models
{
    public class Info_store
    {
        private int id;
        private string email;
        private string phone;
        private string address;

        public Info_store(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Address = row["address"].ToString();
            this.Phone = row["phone"].ToString();
            this.Email = row["email"].ToString();
        }

        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
    }
}
