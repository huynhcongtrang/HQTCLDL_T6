using CDStoreManagement.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDStoreManagement.Utils
{
    public partial class ControlBoxFunction : Form
    {

        public ControlBoxFunction()
        {
            InitializeComponent();
        }

        private void lstFunction_MouseHover(object sender, EventArgs e)
        {
            Point point = lstFunction.PointToClient(Cursor.Position);
            int index = lstFunction.IndexFromPoint(point);
            if (index < 0) return;
            lstFunction.GetItemRectangle(index).Inflate(1, 2);
        }

        private void lstFunction_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Close();
            int index = this.lstFunction.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                switch (index)
                {
                    case 0:
                        using (Utils.AccountFunction.ChangePasswordFunction passwordChange = new AccountFunction.ChangePasswordFunction())
                        {
                            passwordChange.ShowDialog();
                        }
                        break;
                    case 1:
                        using (Utils.PersonalDetails.Personal details = new Utils.PersonalDetails.Personal())
                        {
                            details.DisplayUserDetail(Common1.Id); ;
                            details.ShowDialog();
                        }
                        this.Close();
                        break;
                    

                }
            }
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
