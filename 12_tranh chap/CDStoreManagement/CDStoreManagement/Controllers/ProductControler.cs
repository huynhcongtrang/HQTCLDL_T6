using CDStoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Controllers
{
    public class ProductControler
    {
        private static ProductControler instance;
        public static ProductControler Instance
        {
            get { if (instance == null) instance = new ProductControler(); return instance; }
            private set { instance = value; }
        }

        private ProductControler() { }

        public List<Product> GetListProduct()
        {
            List<Product> list = new List<Product>();
            string query = "EXECUTE dbo.GET_LIST_PRODUCT";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                list.Add(product);
            }
            return list;
        }

        public List<Product> GetListProductByCatalog(int idCatalog)
        {
            List<Product> list = new List<Product>();
            string query = "EXECUTE dbo.GET_LIST_PRODUCT_BUY_CATALOG @ID_CATALOG = " + idCatalog;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Product cata = new Product(item);
                list.Add(cata);
            }
            return list;
        }

        public Product GetProductById(int id)
        {
            string query = "EXECUTE dbo.GET_PRODUCT_BUY_ID @ID = " + id;
            Product product = new Product(DataProvider.Instance.ExecuteQuery(query).Rows[0]);
            return product;
        }

        public bool DeleteProduct(int id)
        {
            string query = "EXECUTE dbo.DELETE_PRODUCT @ID = " + id;
            return Convert.ToBoolean(DataProvider.Instance.ExecuteQuery(query).Rows[0][0]);
        }

        public void InsertProduct(int idCatalog, string typeDisk, string name, string namePerfor, Decimal price, string content, Decimal discount, string image, int total, int totalHire, int totalBuy, DateTime created)
        {
            string query = "EXECUTE dbo.INSERT_PRODUCT @ID_CATALOG = "+idCatalog+" , @TYPE_DISK = '"+typeDisk+"' , @NAME = N'"+name+"', @NAME_PERFOR = N'"+namePerfor+"' , @PRICE = "+price+" , @CONTENT = N'"+content+"' , @DISCOUNT = "+discount+" , @IMAGE = '"+image+"' , @TOTAL = "+total+" , @TOTAL_HIRE = "+totalHire+" , @TOTAL_BUY = "+totalHire+" , @CREATE = '"+created+"'";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public bool UpdateProduct(int id, int id_catalog, string typeDisk, string name, string namePerfor, Decimal price, string content, Decimal discount, string image, int total) {
            string query = "EXECUTE dbo.UPDATE_PRODUCT @ID = "+id+" , @ID_CATALOG = "+id_catalog+" , @TYPE_DISK = '"+typeDisk+"' , @NAME = N'"+name+"' , @NAME_PERFOR = N'"+namePerfor+"' , @PRICE = "+price+" , @CONTENT = N'"+content+"' , @DISCOUNT = "+discount+" , @IMAGE = '"+image+"' , @TOTAL = "+total+"";
            return Convert.ToBoolean(DataProvider.Instance.ExecuteQuery(query).Rows[0][0]);
        }

        public void UpdateTotalAndTotalHireProduct(int id, int total, int totalBuy)
        {
            string query = "EXECUTE dbo.UPDATE_TOTAL_TOTALBUY @ID = "+id+" , @TOTAL = "+total+" , @TOTALBUY = "+totalBuy+"";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public List<Product> GetListProductOrder(string key) {
            List<Product> list = new List<Product>();
            string query = "select * from Product order by " + key;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                list.Add(product);
            }
            return list;
        }
        public List<Product> GetListProductByFillExtend(string queryExtend)
        {
            List<Product> list = new List<Product>();
            string query = "SELECT * FROM Product " + queryExtend;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                list.Add(product);
            }
            return list;
        }
        public void UpdateProduct(int type, int id, int total) {
            string query = "EXECUTE dbo.UPDATE_TOTAL_HIRE_BUY_PRODUCT @TYPE = "+type+", @ID = "+id+", @TOTAL = "+total+" ";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public void UpdateProduct(int id, int total) {
            string query = "EXECUTE dbo.UPDATE_PRODUCT1 @ID = "+id+" , @TOTAL = "+total;
            DataProvider.Instance.ExecuteQuery(query);
        }

        
    }
}
