using CDStoreManagement.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDStoreManagement.Utils.StatisticaFunction
{
    public partial class DetailStatisticalMonth : Form
    {
        public DetailStatisticalMonth()
        {
            InitializeComponent();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadData()
        {
            dgvDoanhthu.DataSource = StaticticalControler.Instance.getDataEveryMonth(DateTime.Now.Year);
        }
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            int year = dtpDate.Value.Year;
            saveFile.FileName = "Doanh thu từng tháng trong năm " + year;
            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {
                bool check;
                try
                {
                    switch (saveFile.FilterIndex)
                    {
                        case 2:
                            check = ExportToExcelM.Instance.Export(dgvDoanhthu, saveFile.FileName, ModeExcelORPDF.XLSX);
                            break;
                        case 3:
                            check = ExportToExcelM.Instance.Export(dgvDoanhthu, saveFile.FileName, ModeExcelORPDF.PDF);
                            break;
                        default:
                            check = ExportToExcelM.Instance.Export(dgvDoanhthu, saveFile.FileName, ModeExcelORPDF.XLS);
                            break;
                    }
                    if (check)
                        MessageBox.Show("Xuất thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Lỗi xuất thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show("Lỗi (Cần cài đặt Office)", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int year = dtpDate.Value.Year;
            dgvDoanhthu.DataSource = StaticticalControler.Instance.getDataEveryMonth(year);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
