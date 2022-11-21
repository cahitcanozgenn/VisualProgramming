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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sonuc = 0;
            int number1 = Convert.ToInt32(textBox1.Text);
            int number2 = Convert.ToInt32(textBox2.Text);
            if(comboBox1.SelectedItem=="TOPLA")
            {
                sonuc = number1 + number2;
                label4.Text = sonuc.ToString();
            }
            else if (comboBox1.SelectedItem == "ÇIKAR")
            {
                sonuc = number1 - number2;
                label4.Text = sonuc.ToString();
            }
            else if (comboBox1.SelectedItem == "ÇARP")
            {
                sonuc = number1 * number2;
                label4.Text = sonuc.ToString();
            }
            else if (comboBox1.SelectedItem == "BÖL")
            {
                sonuc = number1 / number2;
                label4.Text = sonuc.ToString();
            }
            else
            {
                MessageBox.Show("Hatalı Seçim Yaptınız.");
            }
        }
    }
}
