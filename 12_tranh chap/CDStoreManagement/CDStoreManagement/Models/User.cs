using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Models
{
    public class User
    {
        private int id;
        private string name;
        private string sex;
        private int yearBirth;
        private string username;
        private string password;
        private string email;
        private string phone;
        private string address;
        private int position;
        private double salary;
        private string image_link;
        private DateTime created;

        public User(DataRow row) {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Sex = row["sex"].ToString();
            this.YearBirth = (int)row["yearBirth"];
            this.Username = row["username"].ToString();
            this.Password = row["password"].ToString();
            this.Email = row["email"].ToString();
            this.Phone = row["phone"].ToString();
            this.Address = row["address"].ToString();
            this.Position = Convert.ToInt16(row["position"]);
            this.Salary = (Double)Convert.ToDouble(row["salary"].ToString());
            this.Image_link = row["image_link"].ToString();
            this.Created = (DateTime)row["created"];
        }
        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public int Position { get => position; set => position = value; }
        public double Salary { get => salary; set => salary = value; }
        public string Image_link { get => image_link; set => image_link = value; }
        public int Id { get => id; set => id = value; }
        public DateTime Created { get => created; set => created = value; }
        public string Sex { get => sex; set => sex = value; }
        public int YearBirth { get => yearBirth; set => yearBirth = value; }
    }
}
