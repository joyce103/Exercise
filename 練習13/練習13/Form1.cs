using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 練習13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = trackBar3.Value.ToString();
            richTextBox1.BackColor = Color.FromArgb(255,trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
            richTextBox1.BackColor = Color.FromArgb(255, trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = trackBar2.Value.ToString();
            richTextBox1.BackColor = Color.FromArgb(255, trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }
    }
}
