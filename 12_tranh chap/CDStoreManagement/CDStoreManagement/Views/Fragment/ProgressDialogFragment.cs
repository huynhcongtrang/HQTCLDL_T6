using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDStoreManagement.Views.Fragment
{
    public partial class ProgressDialogFragment : UserControl
    {
        public ProgressDialogFragment()
        {
            InitializeComponent();
        }

        int dir = 1;
        private void time_progress_Tick(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar1.Value == 100)
            {
                dir = -1;
                bunifuCircleProgressbar1.animationSpeed = 4;
            }
            else if (bunifuCircleProgressbar1.Value == 0)
            {
                dir = +1;
                bunifuCircleProgressbar1.animationSpeed = 2;
            }
            bunifuCircleProgressbar1.Value += dir;

        }
    }
}
