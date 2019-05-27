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

namespace CDStoreManagement.Utils.CalendarEvent
{
    public partial class EventNotificationInsert : Form
    {
        public EventNotificationInsert()
        {
            InitializeComponent();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool checkNumber(string number)
        {
            int n;
            return int.TryParse(number, out n);
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string title = tbTitleEvent.Text;
            string datetimeBegin = String.Format("{0:yyyy-MM-dd}", dtDateEventBegin.Value) + " " + String.Format("{0:HH:mm:ss}", dtTimeEventBegin.Value);
            string datetimeEnd = String.Format("{0:yyyy-MM-dd}", dtDateEventEnd.Value) + " " + String.Format("{0:HH:mm:ss}", dtTimeEventEnd.Value);
            DateTime date1 = Convert.ToDateTime(datetimeBegin);
            DateTime date2 = Convert.ToDateTime(datetimeEnd);
            if (title.Equals(""))
            {
                MessageBox.Show("Chủ đề trống!");
                return;
            }
            else if (DateTime.Compare(DateTime.Now, date1) > 0)
            {
                MessageBox.Show("Thời gian bắt đầu sau thời gian hiện tại");
                return;
            }
            else if (DateTime.Compare(date1, date2) > 0)
            {
                MessageBox.Show("Thời gian kết thúc sau thời gian bắt đầu");
                return;
            }
            string discount = txDiscount.Text;
            int dicounttemp = 0;
            if (!discount.Equals(""))
            {
                if (!checkNumber(discount))
                {
                    MessageBox.Show("Kiểm tra giảm giá");
                    return;
                }
                dicounttemp = Convert.ToInt32(discount);
            }
            EventControler.Instance.AddEvent(title, datetimeBegin, datetimeEnd, dicounttemp);
            MessageBox.Show("Bạn đã thêm thành công!");
            this.Close();
        }

        private void EventNotificationInsert_Load(object sender, EventArgs e)
        {
            dtDateEventBegin.Value = DateTime.Now;
        }
    }
}
