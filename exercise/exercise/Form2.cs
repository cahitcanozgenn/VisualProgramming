using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string text = "Sepetime Ekle";
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Text = text;
            button2.Text = text;
            button3.Text = text;


            timer1.Enabled = false;
            timer1.Interval = 100;

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            //timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
            if(progressBar1.Value==progressBar1.Maximum)
            {
                timer1.Stop();
                MessageBox.Show("Uygulamayı kapatmaya eminmisin?",
 "Uygulama Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            
        }
    }
}
