using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] sayi = new int[5];
            int toplam = 0;
            for (int j=0;j<sayi.Length;j++)
            {
                sayi[j] = rnd.Next(0,50);
                toplam = toplam + sayi[j];
                if (toplam > 100)
                {
                    MessageBox.Show("Toplam 100'den Büyüktür.");
                    break;
                }
                else
                {
                    
                }
                
            }
            label1.Text = toplam.ToString();
            MessageBox.Show("Sonuc:" + toplam);
            
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 5, 6, 7, 8 };
            int toplam = 0;
            foreach(int sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    listBox2.Items.Add(sayi);
                }
                else
                {
                    listBox3.Items.Add(sayi);
                }
            }
            MessageBox.Show("Sonuc:" + toplam);


        }
    }
}
