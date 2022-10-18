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
    public partial class Form7 : Form
    {
        public Form7()
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
            int number = Convert.ToInt32(textBox1.Text);
            if (checkBox1.Checked == true)
            {
                if (checkBox1.Checked == true && checkBox2.Checked == true || checkBox1.Checked == true && checkBox3.Checked == true)
                {
                    MessageBox.Show("Lütfen Tek Seçim Yapınız.");
                }
                else
                {
                    double sonuc = (number * Convert.ToInt32(checkBox1.Text)) / 100;
                    label2.Text = Convert.ToString(sonuc);
                }


            }
            else if (checkBox2.Checked == true)
            {
                if (checkBox2.Checked == true && checkBox1.Checked == true || checkBox2.Checked == true && checkBox3.Checked == true)
                {
                    MessageBox.Show("Lütfen Tek Seçim Yapınız.");
                }
                else
                {
                    double sonuc = (number * Convert.ToInt32(checkBox2.Text)) / 100;
                    label2.Text = Convert.ToString(sonuc);
                }

            }
            else if (checkBox3.Checked == true)
            {
                double sonuc = (number * Convert.ToInt32(checkBox3.Text)) / 100;
                label2.Text = Convert.ToString(sonuc);
            }
        }
    }
}
