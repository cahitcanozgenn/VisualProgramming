using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = 1;
            }
            else
            {
                progressBar1.Value = progressBar1.Value + 1;
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            //timer1.Stop();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            //timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
