using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessDeclarations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Topla()
        {
            int number1 = Convert.ToInt32(textBox1.Text);
            int number2 = Convert.ToInt32(textBox2.Text);
            int value = number1 + number2;
            label7.Text = value.ToString();
        }
        static int Fark(int sayi1,int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            return sonuc;
        }
        public string bol(int sayi1,int sayi2)
        {
            double sonuc = sayi1 / sayi2;
            return sonuc.ToString();
        }
        private void Carp(int sayi1,int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            label9.Text = sonuc.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Topla();
            int sy1 = Convert.ToInt32(textBox1.Text);
            int sy2 = Convert.ToInt32(textBox2.Text);
            int donen = Fark(sy1, sy2);
            label8.Text = donen.ToString();
            Carp(sy1, sy2);
            label10.Text = bol(sy1, sy2);
        }
    }
}
