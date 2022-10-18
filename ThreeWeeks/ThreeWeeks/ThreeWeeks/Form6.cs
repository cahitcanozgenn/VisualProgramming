using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeWeeks
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem=="%20")
            {
                double sonuc = (Convert.ToInt32(textBox1.Text) * 20) / 100;
                label2.Text = Convert.ToString(sonuc);
            }
            else if (comboBox1.SelectedItem == "%30")
            {
                double sonuc = (Convert.ToInt32(textBox1.Text) * 30) / 100;
                label2.Text = Convert.ToString(sonuc);
            }
            else if (comboBox1.SelectedItem == "%40")
            {
                double sonuc = (Convert.ToInt32(textBox1.Text) * 40) / 100;
                label2.Text = Convert.ToString(sonuc);
            }
            else if (comboBox1.SelectedItem == "%50")
            {
                double sonuc = (Convert.ToInt32(textBox1.Text) * 50) / 100;
                label2.Text = Convert.ToString(sonuc);
            }
        }
    }
}
