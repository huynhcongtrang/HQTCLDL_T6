using CDStoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Controllers
{
    public class CustomerController
    {

        CustomerController() { }
        private static CustomerController instance;

        public static CustomerController Instance
        {
            get { if (instance == null) instance = new CustomerController(); return instance; }
            private set { instance = value; }
        }

        public List<Customer> GetListCustomer()
        {
            List<Customer> list = new List<Customer>();
            string query = "select * from Customer ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                list.Add(customer);
            }
            return list;
        }
        // 1: tat ca
        public int GetTotal(int rule)
        {
            List<Customer> list = new List<Customer>();
            string query = "";
            if (rule == 1)
                query = "select * from Customer ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count;
        }

        public Customer GetCustomerById(int id)
        {
            string query = "EXECUTE dbo.GET_CUSTOMER_BUYID @ID = "+ id;
            Customer cus = new Customer(DataProvider.Instance.ExecuteQuery(query).Rows[0]);
            return cus;
        }

        public bool InsertCustomer(string name, string phone, string address, DateTime created)
        {
            string query = "EXECUTE dbo.INSERT_CUSTOMER @NAME = N'"+name+"' , @PHONE = '"+phone+"' , @ADDRESS = N'"+address+"' , @CREATED = '"+created+"'";
             return Convert.ToBoolean(DataProvider.Instance.ExecuteQuery(query).Rows[0][0]); 
        }

        public bool UpdateCustomer(int id, string name, string phone, string address)
        {
            string query = "EXECUTE dbo.UPDATE_CUSTOMER @ID = "+id+" , @NAME = N'"+name+"' , @PHONE = '"+phone+"' , @ADDRESS = N'"+address+"'";
            return Convert.ToBoolean(DataProvider.Instance.ExecuteQuery(query).Rows[0][0]);
        }

        public void DeleteCustomer(int id)
        {
            string query = "EXECUTE dbo.DELETE_CUSTOMER @id = " + id;
            DataProvider.Instance.ExecuteQuery(query);
        }

        public List<Customer> SearchCustomer(string key)
        {
            List<Customer> list = new List<Customer>();
            string query = "EXECUTE dbo.SEARCH_CUSTOMER @key = N'%"+key+"%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                list.Add(customer);
            }
            return list;
        }

       

        public bool CheckExistCustomer(string phone)
        {
            string query = "EXECUTE CHECK_EXIT_CUSTOMER_BYPHONE @PHONE = '"+phone+"'";
            return Convert.ToBoolean(DataProvider.Instance.ExecuteQuery(query).Rows[0][0]);
        }
        public Customer GetCustomerByPhone(string phone)
        {
            string query = "EXECUTE dbo.GET_CUSTOMER_BYPHONE @PHONE = N'"+phone+"'";
            Customer cus = new Customer(DataProvider.Instance.ExecuteQuery(query).Rows[0]);
            return cus;
        }

    }
}
