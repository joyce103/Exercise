using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 練習12
{
    public partial class Form1 : Form
    {
        int a = 200;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDlg = new OpenFileDialog();
            OpenDlg.ShowDialog();
            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(OpenDlg.FileName);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Text = a.ToString();
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Maximum = 200 - trackBar2.Value;
            textBox1.Text = trackBar1.Value.ToString();
            if (a >= 0) {
                a = trackBar1.Maximum - trackBar1.Value;
                textBox3.Text = a.ToString();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //a -= trackBar1.Value;
            //textBox3.Text = a.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            trackBar2.Maximum = 200 - trackBar1.Value;
            textBox2.Text = trackBar2.Value.ToString();
            if (a >= 0)
            {
                a = trackBar2.Maximum - trackBar2.Value;
                textBox3.Text = a.ToString();
            }
        }
    }
}
