using CDStoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDStoreManagement.Controllers
{
    public class UserControler
    {
        private static UserControler instance;

        public static UserControler Instance
        {
            get { if (instance == null) instance = new UserControler(); return instance; }
            private set { instance = value; }
        }

        private UserControler() { }

        public bool Login(string userName, string passWord)
        {

            string query = "EXECUTE dbo.LOGIN @USERNAME = '"+userName+"', @PASSWORD = '"+passWord+"'";

            return Convert.ToBoolean(DataProvider.Instance.ExecuteQuery(query).Rows[0][0]);
        }

        // cp 
        public List<User> GetListUser()
        {
            List<User> list = new List<User>();
            string query = "select * from Userr ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                User user = new User(item);
                list.Add(user);
            }
            return list;
        }

        public List<User> GetListUserFillByPosition(int position)
        {
            List<User> list = new List<User>();
            string query = "SELECT * FROM dbo.GET_LIST_USER_BYPOSTION("+position+")";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                User user = new User(item);
                list.Add(user);
            }
            return list;
        }
        public User GetUserById(int id)
        {
            string query = "SELECT * FROM dbo.GET_USER_BUYID("+id+")";
            User us = new User(DataProvider.Instance.ExecuteQuery(query).Rows[0]);
            return us;
        }


        // leu user by name
        public User GetUserByUserName(string username)
        {
            string query = "SELECT * FROM dbo.GET_USER_BUY_USERNAME('"+username+"')";
            User us = new User(DataProvider.Instance.ExecuteQuery(query).Rows[0]);
            return us;
        }
        // lấy số lượng nhân viên
        // 0 lay het 1: lay admin 2: lay nhan vien : 3 : kho
        public int GetTotal(int check)
        {
            string query = "SELECT dbo.GET_TOTAL_USER(" + check + ")";
            return Convert.ToInt32(DataProvider.Instance.ExecuteQuery(query).Rows[0][0]);
        }
        public void DeleteUser(int id)
        {
            string query = "EXECUTE dbo.DELETE_USER @ID = "+ id;
            DataProvider.Instance.ExecuteQuery(query);
        }
        public bool CheckExitUsernameAccount(int idUser, string userName)
        {
            string query = "EXECUTE dbo.CHEKC_EXIST_USERNAME @IDUSER = "+idUser+" , @USERNAME = '"+userName+"'";
            return Convert.ToBoolean(DataProvider.Instance.ExecuteQuery(query).Rows[0][0]);
        }
        public bool CheckExitEmailAccount(int idUser, string email)
        {
            
           string query = "EXECUTE dbo.CHEKC_EXIST_EMAIL @IDUSER = "+ idUser+ " , @EMAIL = '"+email+"'";
            return Convert.ToBoolean(DataProvider.Instance.ExecuteQuery(query).Rows[0][0]);
        }
        public void Register(string name,string sex, int yearBirth, string username, string password, string repassword, string email, string phone, string address, int position, double salary, string image_link, DateTime created)
        {
            DataProvider.Instance.ExecuteQuery("exec CD_INSERTACCOUNT @name , @sex , @yearBirth , @userName , @password , @repassword , @email , @phone , @address , @position , @salary , @image_link , @status", new object[] { name,sex,yearBirth, username, password, repassword, email, phone, address, position, salary, image_link, created });

        }
        public void UpdatePasswordUserById(int id, string passwrod) {
            string query = "EXECUTE dbo.UPDATE_PASSWORD_USER @ID = "+id+" , @PASSWORD = '"+passwrod+"'";
            DataProvider.Instance.ExecuteQuery(query);
        }
        // cap nhat 
        public void UpdateUser(int id, string name,string sex, int yearBirth, string password, string email,string phone , string address , int position , double salary, string image_link) {
            string query = "EXECUTE dbo.UPDATE_USER @ID = "+id+" , @NAME = N'"+name+"', @SEX = N'"+sex+"' , @YEARBIRTH = "+yearBirth+" , @PASSWORD = N'"+password+"' , @EMAIL = N'"+email+"' , @PHONE = '"+phone+"' , @ADDRESS = N'"+address+"' , @POSITION = "+position+" , @SALARY = "+salary+" , @IMAGE_LINK = N'"+image_link+"'";
            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
