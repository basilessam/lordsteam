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
    public partial class dessert : UserControl
    {
        public dessert()
        {
            InitializeComponent();
        }
        public static int x, count = 0;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = 5;
            count += x;
            
        }

        private void dessert_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = 5;
            count += x;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            x = 7;
            count += x;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            x = 8;
            count += x;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            x = 4;
            count += x;
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            x = 3;
            count += x;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = 6;
            count += x;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = 4;
            count += x;
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            x = 5;
            count += x;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label17.Text = count.ToString();
        }
    }
}
