using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SevenWeeks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Interval = 100;
            timer2.Interval = 1;
            //timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            //timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add("Cahit Can ÖZGEN");
            if(progressBar1.Value==progressBar1.Maximum)
            {
                progressBar1.Value = 1;
            }
            else
            {
                progressBar1.Value = progressBar1.Value + 1;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            //timer.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar2.Value == progressBar2.Maximum)
            {
                progressBar2.Value = 10;
                progressBar3.Value = progressBar3.Value + 10;
            }
            else
            {
                progressBar2.Value = progressBar2.Value + 1;
            }
            if(progressBar3.Value==progressBar3.Maximum)
            {
                timer2.Stop();
                MessageBox.Show("Yükleme Tamamlandı");
                progressBar2.Value = 0;
                progressBar3.Value = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }
    }
}
