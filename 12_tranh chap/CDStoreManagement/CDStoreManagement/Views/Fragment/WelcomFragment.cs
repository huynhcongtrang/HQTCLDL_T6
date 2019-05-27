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
    public partial class WelcomFragment : UserControl
    {
        public WelcomFragment()
        {
            InitializeComponent();
            text1.Location = new Point(-470, 220);
            text2.Location = new Point(904, 144);
        }


        private void animation_Tick(object sender, EventArgs e)
        {
            text1.Location = new Point(text1.Location.X + 1, text1.Location.Y);
            text2.Location = new Point(text2.Location.X - 1, text2.Location.Y);

            if (text1.Location.X == 180)
            {
                loadComponent.Stop();
            }
        }

        private void WelcomFragment_Load(object sender, EventArgs e)
        {
                loadComponent.Interval = 5;
                loadComponent.Start();
                loadComponent.Tick += animation_Tick;
        }
    }
}
