using CDStoreManagement.Common;
using CDStoreManagement.Controllers;
using CDStoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace CDStoreManagement.Views.Activities
{
    public partial class CategoryFragment : UserControl
    {
        public CategoryFragment()
        {
            InitializeComponent();
            if (Common1.postionPermistion == Common1.positionNhanVien)
            {
                btnAddCatalog.Visible = false;
                btnDelete.Visible = false;
                btnEditCatalog.Visible = false;
                bunifuCustomLabel14.Visible = false;
                bunifuCustomLabel15.Visible = false;
                bunifuCustomLabel16.Visible = false;
            }

        }

        public void LoadListCatalog()
        {
            List<Catalog> list = CatalogControler.Instance.GetListCatalog();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã", typeof(int));
            dt.Columns.Add("Tên danh mục", typeof(string));
            CultureInfo culture = new CultureInfo("vi-VN");
            foreach (Catalog item in list)
            {
                dt.Rows.Add(item.Id, CatalogControler.Instance.GetCatalogById(item.Id).Name);

            }

            dtgvCatalog.ForeColor = Color.Black;
            dtgvCatalog.DataSource = dt;
        }
        public int SelectCatalog()
        {
            int id = 0;
            if (dtgvCatalog.SelectedRows.Count > 0)
            {
                try
                {
                    id = Convert.ToInt16(dtgvCatalog.SelectedRows[0].Cells["Mã"].Value.ToString());
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

        private void CategoryFragment_Load(object sender, EventArgs e)
        {
            //phan nay m load database vao datagridview nhe
            dtgvCatalog.MouseClick += new MouseEventHandler(my_datagridview_MouseClick);
        }

        private void my_datagridview_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                int position = dtgvCatalog.HitTest(e.X, e.Y).RowIndex;

                if (position >= 0)
                {
                    contextMenuStrip.Items.Add("Thêm").Name = "Insert";
                    contextMenuStrip.Items.Add("Xoá").Name = "Remove";
                    contextMenuStrip.Items.Add("Sửa").Name = "Update";
                }
                contextMenuStrip.Show(dtgvCatalog, new Point(e.X, e.Y));

                //event Click
                contextMenuStrip.ItemClicked += new ToolStripItemClickedEventHandler(my_itemClicked);
            }

        }

        private void my_itemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "Insert":
                    using (Utils.CatelogFunction.ShowFunctionInsertCatelog insert = new Utils.CatelogFunction.ShowFunctionInsertCatelog())
                    {
                        insert.ShowDialog();
                        LoadListCatalog();
                    }
                    break;
                case "Remove":
                    DeleteCatalog();
                    break;
                case "Update":
                    EditCatalog();
                    break;
            }
        }
        private void AddCatalog()
        {
            using (Utils.CatelogFunction.ShowFunctionInsertCatelog insert = new Utils.CatelogFunction.ShowFunctionInsertCatelog())
            {
                insert.ShowDialog();
            }
            LoadListCatalog();
        }

        private void btnAddCatalog_Click(object sender, EventArgs e)
        {
            AddCatalog();
        }
        //xóa danh mục

        bool CheckProductExists(int idCatalog) // kiểm tra có tồn tại sản phẩm không
        {
            return CatalogControler.Instance.CheckExistsProduct(idCatalog);
        }
        private void DeleteCatalog()
        {
            int idCatalog = SelectCatalog();
            if (idCatalog != 0)
            {
                if (CheckProductExists(idCatalog))
                {
                    if (MessageBox.Show("Danh mục này đang chứa sản phẩm. Bạn có muốn xoá ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        if (CatalogControler.Instance.DeleteCatalogWithProduct(idCatalog))
                        {
                            LoadListCatalog();
                            MessageBox.Show("Thực hiện thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Thực hiện không thành công! Sản phẩm này đã được giao dịch");
                        }
                    }
                }
                else
                {
                    CatalogControler.Instance.DeleteCatalogWithProduct(idCatalog);
                    LoadListCatalog();
                    MessageBox.Show("Thực hiện thành công!");
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCatalog();
        }

        //sửa danh mục
        private void EditCatalog()
        {
            int id = SelectCatalog();
            if (id != 0)
            {
                using (Utils.CatelogFunction.ShowFunctionUpdateCatelog update = new Utils.CatelogFunction.ShowFunctionUpdateCatelog())
                {
                    update.DisplayDetailProduct(id);
                    update.ShowDialog();
                }
            }
            LoadListCatalog();
        }
        private void btnEditCatalog_Click(object sender, EventArgs e)
        {
            EditCatalog();
        }
        //sửa danh mục  
    }
}
