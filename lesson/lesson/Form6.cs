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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sonuc;
            double number = Convert.ToDouble(textBox1.Text);
            if(comboBox1.SelectedItem=="%10")
            {
                sonuc = (number * 10) / 100;
                label1.Text = sonuc.ToString();
            }
            else if (comboBox1.SelectedItem == "%30")
            {
                sonuc = (number * 30) / 100;
                label1.Text = sonuc.ToString();
            }
            else if (comboBox1.SelectedItem == "%50")
            {
                sonuc = (number * 50) / 100;
                label1.Text = sonuc.ToString();
            }
            else
            {
                MessageBox.Show("Hata");
            }

        }
    }
}
