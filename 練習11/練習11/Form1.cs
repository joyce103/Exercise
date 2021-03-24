using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 練習11
{
    public partial class Form1 : Form
    {
        int i = 1;
        int k = 4;
        int j = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[1];
            pictureBox2.Image = imageList1.Images[4];
            pictureBox3.Image = imageList1.Images[0];
            button2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            pictureBox1.Image = imageList1.Images[i];
            if (i == 5)
            {
                i = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            k++;
            pictureBox2.Image = imageList1.Images[k];
            if (k == 5)
            {
                k = 0;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            j++;
            pictureBox3.Image = imageList1.Images[j];
            if (j == 5)
            {
                j = 0;
            }
        }
    }
}
