using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDStoreManagement.Controllers;
using CDStoreManagement.Models;
using System.Globalization;
using System.Threading;
using CDStoreManagement.Common;

namespace CDStoreManagement.Views.Activities
{
    public partial class ProductFragment : UserControl
    {
        public ProductFragment()
        {
            InitializeComponent();
            if (Common1.postionPermistion == Common1.positionNhanVien)
            {
                bunifuCustomLabel14.Visible = false;
                bunifuCustomLabel15.Visible = false;
                bunifuCustomLabel16.Visible = false;
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnEdit.Visible = false;
            }
            LoadCatalog();
            LoadListProduct();

        }

        #region method

        public void LoadCatalog()
        {
            cbbCatalog.Items.Clear();
            List<Catalog> list = CatalogControler.Instance.GetListCatalog();
            foreach (Catalog item in list)
            {
                cbbCatalog.Items.Add(item.Name.ToString());
            }
        }
        bool CheckExitProduct(int total, int totalHire, int totalBuy)
        {
            int result = total - totalHire - totalBuy;
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        void LoadListProductFiel(List<Product> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã", typeof(int));
            dt.Columns.Add("Danh mục", typeof(string));
            dt.Columns.Add("Loại đĩa", typeof(string));
            dt.Columns.Add("Tên đĩa", typeof(string));
            dt.Columns.Add("Giá", typeof(string));
            dt.Columns.Add("Số lượng", typeof(double));
            dt.Columns.Add("Trạng thái", typeof(string));
            dt.Columns.Add("Ngày tạo", typeof(string));

            foreach (Product item in list)
            {
                string exitProduct = CheckExitProduct(item.Total, item.TotalHire, item.TotalBuy) ? "Còn hàng" : "Hết hàng";
                dt.Rows.Add(item.Id, CatalogControler.Instance.GetCatalogById(item.IdCatalog).Name, item.TypeDisk, item.Name, (item.Price - item.Discount).ToString("N"), item.Total, exitProduct, String.Format("{0:dd/MM/yyyy}", item.Created));
            }
            lbTotalProduct.Text = list.Count.ToString();
            dtgvProduct.ForeColor = Color.Black;
            dtgvProduct.DataSource = dt;
            dtgvProduct.ForeColor = Color.Black;

        }
        public void LoadListProduct()
        {
            List<Product> list = ProductControler.Instance.GetListProduct();
            LoadListProductFiel(list);

        }
        public int SelectProduct()
        {
            int id = 0;
            if (dtgvProduct.SelectedRows.Count > 0)
            {
                try
                {
                    id = Convert.ToInt16(dtgvProduct.SelectedRows[0].Cells["Mã"].Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn không chọn được cái này !");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm !");
            }
            return id;
        }
        #endregion

        #region event

        private void btnFunctions_Click(object sender, EventArgs e)
        {
            new Utils.ShowFunctionInsert();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Utils.ShowFunctionInsert insert = new Utils.ShowFunctionInsert())
            {
                insert.ShowDialog();
            }
            LoadListProduct();
        }
        //edit san pham
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int idProduct = SelectProduct();

            if (idProduct != 0)
            {
                using (Utils.ShowFunctionUpdate update = new Utils.ShowFunctionUpdate())
                {
                    update.DisplayDetailProduct(idProduct);
                    update.ShowDialog();

                }
            }
            LoadListProduct();
        }

        // xoa san pham
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int idPro = SelectProduct();
            if (idPro != 0)
            {
                if (MessageBox.Show("Bạn có muốn xoá ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    if (!ProductControler.Instance.DeleteProduct(idPro))
                    {
                        MessageBox.Show("Thực hiện không thành công ! Sản phẩm này hiện đang giao dịch !");
                        return;
                    }
                    LoadListProduct();
                }

            }
        }




        #endregion

        private void cbbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = "";
            string keyteamp = cbbOrder.Text;
            if (keyteamp.Equals("Không"))
            {
                LoadListProduct();
                return;
            }
            if (keyteamp.Equals("ID"))
            {
                key = "id";
            }
            else if (keyteamp.Equals("Ngày tạo"))
            {
                key = "created";
            }
            List<Product> list = ProductControler.Instance.GetListProductOrder(key);
            LoadListProductFiel(list);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadListProduct();
            cbbStatus.Text = "Không";
            cbbCatalog.Text = "Không";
            tbSearchName.Text = "Tìm kiếm ...";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string queryExtend = "";
            int countTemp = 0; // bieen dem xem coi bao nhieu truong loc
            string temp = ""; // bien tam thoi
            string nameProduct = tbSearchName.Text;
            string catalog = cbbCatalog.Text;
            string status = cbbStatus.Text;
            if (!nameProduct.Equals("Tìm kiếm ..."))
            {
                if (countTemp == 0)
                {
                    queryExtend = "where name like N'%" + nameProduct + "%'";
                }
                else
                {
                    temp = " and name like N'%" + nameProduct + "%'";
                    queryExtend += temp;
                }
                countTemp++;
            }
            if (!catalog.Equals("Không"))
            {
                if (countTemp == 0)
                {
                    queryExtend = "where id_catalog = " + CatalogControler.Instance.GetCatalogByName(cbbCatalog.Text).Id;
                }
                else
                {
                    temp = " and id_catalog = " + CatalogControler.Instance.GetCatalogByName(cbbCatalog.Text).Id;
                    queryExtend += temp;
                }
                countTemp++;
            }
            if (!status.Equals("Không"))
            {
                if (status.Equals("Còn hàng"))
                {
                    if (countTemp == 0)
                    {
                        queryExtend = "WHERE total - total_buy - total_hire > 0";
                    }
                    else
                    {
                        temp = " and total - total_buy - total_hire > 0";
                        queryExtend += temp;
                    }
                }
                else if (status.Equals("Hết hàng"))
                {
                    if (countTemp == 0)
                    {
                        queryExtend = "WHERE total - total_buy - total_hire <= 0";
                    }
                    else
                    {
                        temp = " and total - total_buy - total_hire <= 0";
                        queryExtend += temp;
                    }
                }
                countTemp++;
            }
            List<Product> list = ProductControler.Instance.GetListProductByFillExtend(queryExtend);
            LoadListProductFiel(list);
            countTemp = 0;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            int idPro = SelectProduct();
            if (idPro != 0)
            {
                using (Utils.ProductFunction.ShowFunctionDetailProduct detailProduct = new Utils.ProductFunction.ShowFunctionDetailProduct())
                {
                    detailProduct.ShowDetailProduct(idPro);
                    detailProduct.ShowDialog();
                }
            }
        }
    }
}
