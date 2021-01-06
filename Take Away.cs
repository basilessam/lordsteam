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
    public partial class Take_Away : UserControl
    {
        public Take_Away()
        {
            InitializeComponent();
        }
        public static int x, count = 0;

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = 15;
            count += x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = 19;
            count += x;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            x = 25;
            count += x;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            x = 27;
            count += x;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = 6;
            count += x;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = 8;
            count += x;
        }
    }
}
