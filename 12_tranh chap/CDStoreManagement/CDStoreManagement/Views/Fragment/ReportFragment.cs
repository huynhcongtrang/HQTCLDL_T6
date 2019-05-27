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

namespace CDStoreManagement.Views.Activities
{
    public partial class ReportFragment : UserControl
    {
        public ReportFragment()
        {

            InitializeComponent();
        }

        //

        public void LoadData() {
            rdMonth.Checked = false;
            rdnDay.Checked = false;
            dgvMuaDia.DataSource = ReportControler.Instance.getReportBuy() ;
            dgvThueDia.DataSource = ReportControler.Instance.getReportHire();
            decimal sum = 0;
            DataTable dataTotalBuy = ReportControler.Instance.getTotalBuy();
            if (dataTotalBuy.Rows.Count > 0 && !dataTotalBuy.Rows[0][0].ToString().Equals(""))
            {
                object totalB = dataTotalBuy.Rows[0][0];
                sum += (decimal)totalB;
            }
            else
            {
                sum += 0;
            }

            DataTable dataTotalHire = ReportControler.Instance.getTotalHire();
            if (dataTotalHire.Rows.Count > 0 && !dataTotalHire.Rows[0][0].ToString().Equals(""))
            {
                object totalH = dataTotalHire.Rows[0][0];
                sum += (decimal)totalH;
            }
            else
            {
                sum += 0;
            }
            lbTime.Text = "Tất cả";
            lbTotalRevue.Text = sum.ToString("N");

        }
        private void rdnDay_CheckedChanged(object sender, EventArgs e)
        {
            dtFillDate.Enabled = true;
            dtFillMonth.Enabled = false;
        }

        private void rdMonth_CheckedChanged(object sender, EventArgs e)
        {
            dtFillDate.Enabled = false;
            dtFillMonth.Enabled = true;
        }
        private void btnFilter_Click_1(object sender, EventArgs e)
        {   
            decimal sum = 0;
            if (rdnDay.Checked)
            {
                DateTime  fillDate = dtFillDate.Value;

                DataTable dataBuyDay = ReportControler.Instance.getReportBuyDay(fillDate.Day, fillDate.Month, fillDate.Year);
                dgvMuaDia.DataSource = dataBuyDay;

                DataTable dataHireDay = ReportControler.Instance.getReportHireDay(fillDate.Day, fillDate.Month, fillDate.Year);
                dgvThueDia.DataSource = dataHireDay;

                DataTable dataTotalBuy = ReportControler.Instance.getTotalBuy(fillDate.Day, fillDate.Month, fillDate.Year);
                if (dataTotalBuy.Rows.Count > 0 && !dataTotalBuy.Rows[0][0].ToString().Equals(""))
                {
                    object totalB = dataTotalBuy.Rows[0][0];
                    sum += (decimal)totalB;
                }
                else
                {
                    sum += 0;
                }

                DataTable dataTotalHire = ReportControler.Instance.getTotalHire(fillDate.Day, fillDate.Month, fillDate.Year);
                if (dataTotalHire.Rows.Count > 0 && !dataTotalHire.Rows[0][0].ToString().Equals(""))
                {
                    object totalH = dataTotalHire.Rows[0][0];
                    sum += (decimal)totalH;
                }
                else
                {
                    sum += 0;
                }
                lbTime.Text = fillDate.Day + " - " + fillDate.Month + " - " + fillDate.Year;
                lbTotalRevue.Text = sum.ToString("N");
                

            }
            else if (rdMonth.Checked)
            {
                DateTime fillMonth = dtFillMonth.Value;
                DataTable dataBuyMonth = ReportControler.Instance.getReportBuyMonth(fillMonth.Month, fillMonth.Year);
                dgvMuaDia.DataSource = dataBuyMonth;

                DataTable dataHireMonth = ReportControler.Instance.getReportHireMonth(fillMonth.Month, fillMonth.Year);
                dgvThueDia.DataSource = dataHireMonth;

                DataTable dataTotalBuy = ReportControler.Instance.getTotalBuy(0, fillMonth.Month, fillMonth.Year);
                if (dataTotalBuy.Rows.Count > 0 && !dataTotalBuy.Rows[0][0].ToString().Equals(""))
                {
                    object totalB = dataTotalBuy.Rows[0][0];
                    sum += (decimal)totalB;
                }
                DataTable dataTotalHire = ReportControler.Instance.getTotalHire(0, fillMonth.Month, fillMonth.Year);
                if (dataTotalHire.Rows.Count > 0 && !dataTotalHire.Rows[0][0].ToString().Equals(""))
                {
                    object totalH = dataTotalHire.Rows[0][0];
                    sum += (decimal)totalH;
                }
                lbTime.Text = fillMonth.Month + " - " + fillMonth.Year;
                lbTotalRevue.Text = sum.ToString("N");
                //dgvKQL.Rows.Add();
                //dgvKQL.Rows[0].Cells["total"].Value = sum;
                //dgvKQL.Rows[0].Cells["created"].Value = fillMonth.Month + " - " + fillMonth.Year;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
