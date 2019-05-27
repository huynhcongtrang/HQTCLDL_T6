using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CDStoreManagement.Controllers;

namespace CDStoreManagement.Views.Activities
{
    public partial class pnlSlideBar : UserControl
    {
        public pnlSlideBar()
        {

            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(card1, 5);
            Bunifu.Framework.Lib.Elipse.Apply(card2, 5);
            Bunifu.Framework.Lib.Elipse.Apply(card3, 5);
            Bunifu.Framework.Lib.Elipse.Apply(card4, 5);

        }




        #region method
        public void LoadChart(string year)
        {
            string fillYear = "and Year(a.created) = '" + year + "'";
            string thang1 = StaticticalControler.Instance.getDataStatisticalByDayMonthYear("and MONTH(a.created) = '1' " + fillYear).ToString();
            string thang2 = StaticticalControler.Instance.getDataStatisticalByDayMonthYear("and MONTH(a.created) = '2' " + fillYear).ToString(); ;
            string thang3 = StaticticalControler.Instance.getDataStatisticalByDayMonthYear("and MONTH(a.created) = '3' " + fillYear).ToString(); ;
            string thang4 = StaticticalControler.Instance.getDataStatisticalByDayMonthYear("and MONTH(a.created) = '4' " + fillYear).ToString(); ;
            string thang5 = StaticticalControler.Instance.getDataStatisticalByDayMonthYear("and MONTH(a.created) = '5' " + fillYear).ToString(); ;
            string thang6 = StaticticalControler.Instance.getDataStatisticalByDayMonthYear("and MONTH(a.created) = '6' " + fillYear).ToString(); ;
            string thang7 = StaticticalControler.Instance.getDataStatisticalByDayMonthYear("and MONTH(a.created) = '7' " + fillYear).ToString(); ;
            string thang8 = StaticticalControler.Instance.getDataStatisticalByDayMonthYear("and MONTH(a.created) = '8' " + fillYear).ToString(); ;
            string thang9 = StaticticalControler.Instance.getDataStatisticalByDayMonthYear("and MONTH(a.created) = '9' " + fillYear).ToString(); ;
            string thang10 = StaticticalControler.Instance.getDataStatisticalByDayMonthYear("and MONTH(a.created) = '10' " + fillYear).ToString(); ;
            string thang11 = StaticticalControler.Instance.getDataStatisticalByDayMonthYear("and MONTH(a.created) = '11' " + fillYear).ToString(); ;
            string thang12 = StaticticalControler.Instance.getDataStatisticalByDayMonthYear("and MONTH(a.created) = '12' " + fillYear).ToString(); ;
            Series S1 = new Series("Doanh thu");
            chart1.Series.Clear();
            if (chart1.Series.Contains(S1))
            {
                MessageBox.Show("Exists");
            }
            else
            {

                S1.Points.AddXY(1, thang1);
                S1.Points.AddXY(2, thang2);
                S1.Points.AddXY(3, thang3);
                S1.Points.AddXY(4, thang4);
                S1.Points.AddXY(5, thang5);
                S1.Points.AddXY(6, thang6);
                S1.Points.AddXY(7, thang7);
                S1.Points.AddXY(8, thang8);
                S1.Points.AddXY(9, thang9);
                S1.Points.AddXY(10, thang10);
                S1.Points.AddXY(11, thang11);
                S1.Points.AddXY(12, thang12);
                chart1.Series.Add(S1);
            }

        }
        public void LoadPopular(int year) {

            // Phổ biến
            DataTable mostproducts = StaticticalControler.Instance.getMostpurchasedproducts(year);
            if (mostproducts.Rows.Count > 0)
            {
                DataTable totalProductBuy = StaticticalControler.Instance.getTotalProduct(year);
                int sl = Int32.Parse(totalProductBuy.Rows[0][0].ToString());

                if (mostproducts.Rows[0]["name"].ToString() != null)
                {
                    txtProb1.Text = mostproducts.Rows[0]["name"].ToString();
                    prob1.Value = Int32.Parse(mostproducts.Rows[0]["sl"].ToString()) * 100 / sl;
                }
                else
                {
                    txtProb1.Text = "Item 1";
                    prob1.Value = 0;

                }
                if (mostproducts.Rows.Count > 1)
                {
                    txtProb2.Text = mostproducts.Rows[1]["name"].ToString();
                    prob2.Value = Int32.Parse(mostproducts.Rows[1]["sl"].ToString()) * 100 / sl;

                }
                else
                {
                    txtProb2.Text = "Item 2";
                    prob2.Value = 0;
                }
                if (mostproducts.Rows.Count > 2)
                {
                    txtProb3.Text = mostproducts.Rows[2]["name"].ToString();
                    prob3.Value = Int32.Parse(mostproducts.Rows[2]["sl"].ToString()) * 100 / sl;

                }
                else
                {
                    txtProb3.Text = "Item 3";
                    prob3.Value = 0;
                }

                if (mostproducts.Rows.Count > 3)
                {
                    txtProb4.Text = mostproducts.Rows[3]["name"].ToString();
                    prob4.Value = Int32.Parse(mostproducts.Rows[3]["sl"].ToString()) * 100 / sl;
                }
                else
                {
                    txtProb4.Text = "Item 4";
                    prob4.Value = 0;
                }

            }
            else
            {
                txtProb1.Text = "Item 1";
                txtProb2.Text = "Item 2";
                txtProb3.Text = "Item 3";
                txtProb4.Text = "Item 4";
                prob1.Value = 0;
                prob2.Value = 0;
                prob3.Value = 0;
                prob4.Value = 0;
            }



            DataTable nerestYear = StaticticalControler.Instance.getNerestYear(year);
            DataTable nearstYear1 = StaticticalControler.Instance.getNerestYear(year - 1);

            if (nerestYear.Rows.Count > 0 && nearstYear1.Rows.Count > 0)
            {

                int value1;
                int value2;

                if (nerestYear.Rows[0][0] == DBNull.Value)
                {
                    value1 = 0;

                }
                else
                {
                    value1 = Convert.ToInt32(nerestYear.Rows[0][0]);

                }

                if (nearstYear1.Rows[0][0] == DBNull.Value)
                {
                    value2 = 0;
                }
                else
                {
                    value2 = Convert.ToInt32(nearstYear1.Rows[0][0]);
                }
                if (value1 != 0 && value2 != 0)
                {
                    int value11 = value1;
                    int temp;
                    int dem = 0;
                    do
                    {
                        temp = value1 % 10;
                        value1 /= 10;
                        dem++;
                    } while (value1 > 0);


                    if (value11 / value2 > 100)
                    {
                        int themso0 = (int)Math.Pow(10, (dem - 1));
                        int bien = value11 / (temp * themso0);
                        int giatri = (bien * (int)Math.Pow(10, (dem)));
                        proNearestYear.MaxValue = giatri;
                        proNearestYear.Value = (value11 - value2) / value2;
                    }
                    else if (value11 / value2 <= 100)
                    {
                        proNearestYear.MaxValue = 100;
                        proNearestYear.Value = (value11 - value2) / value2;
                    }
                }

                else if (value1 != 0 && value2 == 0)
                {
                    proNearestYear.MaxValue = 100;
                    proNearestYear.Value = 100;
                }
                else if (value1 == 0 && value2 != 0)
                {
                    proNearestYear.MaxValue = 100;
                    proNearestYear.Value = -100;
                }
                else
                {
                    proNearestYear.MaxValue = 100;
                    proNearestYear.Value = 0;
                }

            }
        }
        public void LoadData(DateTime date)
        {
            //filldate
            string fillDate = "and a.created  = '" + String.Format("{0:yyyyMMdd}", date) + "'";
            
            lbRevenueDay.Text = StaticticalControler.Instance.getDataStatisticalByDayMonthYear(fillDate).ToString("N") + " đồng";

            string fillYear = "and Year(a.created) = '" + String.Format("{0:yyyy}", date) + "'";
            
            string fillMonth = "and MONTH(a.created) = '" + String.Format("{0:MM}", date) + "' " + fillYear;
            lbRevenueMonth.Text = StaticticalControler.Instance.getDataStatisticalByDayMonthYear(fillMonth).ToString("N") + " đồng";

            lbRevenueYear.Text = StaticticalControler.Instance.getDataStatisticalByDayMonthYear(fillYear).ToString("N") + " đồng";
         
            //damage 
            lbRevenueDamage.Text = StaticticalControler.Instance.GetDamage("").ToString("N") + " đồng";
            
            // chart
            LoadChart(String.Format("{0:yyyy}", date));

            // popular
            LoadPopular(date.Year);
        }
        #endregion

        #region event

        private void loadData_Tick(object sender, EventArgs e)
        {
            loadData.Stop();
        }

        void renderChart()
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadData(Convert.ToDateTime(dtpStatistical.Value));
        }

        private void btnDetailMonth_Click(object sender, EventArgs e)
        {
            using (Utils.StatisticaFunction.DetailStatisticalMonth detail = new Utils.StatisticaFunction.DetailStatisticalMonth())
            {
                detail.LoadData();
                detail.ShowDialog();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadData(DateTime.Now);
        }
        #endregion


    }
}
