using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class Delivery : UserControl
    {
        public Delivery()
        {
            InitializeComponent();
        }
        public static int x, count = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            x = 20;

            count = (count + x);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = 26;

            count = (count + x);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = 12;

            count = (count + x);
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }
    }
}
