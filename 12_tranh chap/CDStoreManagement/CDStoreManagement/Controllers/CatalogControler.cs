using CDStoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Controllers
{
    public class CatalogControler
    {
        CatalogControler() { }
        private static CatalogControler instance;
        public static CatalogControler Instance
        {
            get { if (instance == null) instance = new CatalogControler(); return instance; }
            private set { instance = value; }
        }

        public List<Catalog> GetListCatalog()
        {
            List<Catalog> list = new List<Catalog>();
            string query = "SET TRAN ISOLATION LEVEL READ UNCOMMITTED BEGIN TRAN EXECUTE dbo.GET_LIST_CATALOG COMMIT";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Catalog catalog = new Catalog(item);
                list.Add(catalog);
            }
            return list;
        }
        public Catalog GetCatalogById(int id) {            
            string query = "EXECUTE dbo.GET_CATALOG_BY_ID @id = "+id;
            Catalog ca = new Catalog(DataProvider.Instance.ExecuteQuery(query).Rows[0]);
            return ca;
        }
        public Catalog GetCatalogByName(String name)
        {
            string query = "EXECUTE GET_CATALOG_BY_NAME	@NAME = N'"+name+"'";
            Catalog ca = new Catalog(DataProvider.Instance.ExecuteQuery(query).Rows[0]);
            return ca;
        }

        public bool CheckExistsProduct(int idCatalog)
        {
            string query = "EXECUTE dbo.CHECK_PRODUCT_EXIT_CATALOG @ID = " + idCatalog;
            return Convert.ToBoolean(DataProvider.Instance.ExecuteQuery(query).Rows[0][0]);
        }

        public bool DeleteCatalogWithProduct(int id)
        {
            string query = "EXECUTE dbo.DELETE_CATALOG @ID = " + id;
            return Convert.ToBoolean(DataProvider.Instance.ExecuteQuery(query).Rows[0][0]);
        }

        public string InsertCatalog(string name)
        {
            string query = "EXECUTE INSERT_CATALOG @NAME = N'" + name + "'";
            return DataProvider.Instance.ExecuteQuery(query).Rows[0][0].ToString();
        }

        public bool UpdateCatalog(int id, string name)
        {
            string query = "EXECUTE dbo.UPDATE_CATALOG @Id = " + id + " , @Name = N'" + name + "'";
            return Convert.ToBoolean(DataProvider.Instance.ExecuteQuery(query).Rows[0][0]);
        }


    }
}
