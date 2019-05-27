using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Models
{
    public class Transaction
    {
        private int id;
        private int id_customer;
        private int id_user;
        private int type;
        private DateTime created;

        public Transaction(DataRow row) {
            this.Id = (int)row["id"];
            this.Id_customer = (int)row["id_customer"];
            this.Id_user = (int)row["id_user"];
            this.Type = Convert.ToInt32(row["type"]);
            this.Created = (DateTime)row["created"];
        }

        public int Id { get => id; set => id = value; }
        public int Id_customer { get => id_customer; set => id_customer = value; }
        public int Id_user { get => id_user; set => id_user = value; }
        public int Type { get => type; set => type = value; }
        public DateTime Created { get => created; set => created = value; }
    }
}
