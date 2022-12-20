using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucgen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a, b, c;
            a = textBox1.Text;
            b = textBox2.Text;
            c = textBox3.Text;
            if (a == b && a == c)
            {
                MessageBox.Show("Eşkenar Üçgen");
            }
            else if (a == b || a == c || b == c)
            {
                MessageBox.Show("İkizkenar Üçgen");
            } 
            else
            {
                MessageBox.Show("Çeşitkenar Üçgen");
            }
               
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if(textBox4.Text=="Yaz")
            {
                label4.Text = "Haziran,Temmuz,Ağustos";
            }
            else if(textBox4.Text=="Kış")
            {
                label4.Text = "Ocak,Şubat,Mart";
            }
            else if(textBox4.Text=="Sonbahar")
            {
                label4.Text = "Ekim,Kasım,Aralık";
            }
            else if(textBox4.Text=="İlkbahar")
            {
                label4.Text = "Nisan,Mayıs";
            }
        }
    }
}
