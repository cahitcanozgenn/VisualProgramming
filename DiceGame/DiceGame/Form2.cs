using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string firstGamer { get; set; }
        public string secondGamer { get; set; }
        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Text = firstGamer;
            button2.Text = secondGamer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(6);
            int sayi1 = rnd.Next(6);
            pictureBox1.Image = ımageList1.Images[sayi];
            pictureBox2.Image = ımageList1.Images[sayi1];
            int toplam = ((sayi + 1) + (sayi1 + 1));
            if (toplam > 0)
            {
                label1.Text = Convert.ToString(toplam);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(6);
            int sayi1 = rnd.Next(6);
            pictureBox1.Image = ımageList1.Images[sayi];
            pictureBox2.Image = ımageList1.Images[sayi1];
            int toplam = ((sayi + 1) + (sayi1 + 1));
            if (toplam > 0)
            {
                label2.Text = Convert.ToString(toplam);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(label1.Text)>Convert.ToInt32(label2.Text))
            {
                MessageBox.Show("Oyunu Kazanan: " + firstGamer);
            }
            if (Convert.ToInt32(label1.Text)==Convert.ToInt32(label2.Text))
            {
                MessageBox.Show("BERABERLİK");
            }
            else
            {
                MessageBox.Show("Oyunu Kazanan: " + secondGamer);
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
