using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AskerlikSorgulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                int sayac = 0;
                int yas;
                string ad, soyad;
                DateTime dogum = new DateTime();
                TimeSpan fark;
                ad = textBox1.Text;
                soyad = textBox2.Text;
                dogum = DateTime.Parse(dateTimePicker1.Text); //convert ediliyor datetime oldugu için
                fark = DateTime.Now.Date.Subtract(dogum); //şimdiki zamandan dogum çıkarılıyor
                yas = Convert.ToInt32(fark.TotalDays); //farkın gün sayısını intergera çeviriyor
                yas = yas / 365;
                label4.Text = ad + " " + soyad + "\n" +
                    "Bu gün itibariyle " + yas.ToString() + " yaşındadır.";
                if (yas >= 20)
                {
                    FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\user.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(textBox1.Text + " ");
                    sw.Write(textBox2.Text + " ");
                    sw.Write(dateTimePicker1.Text);
                    sw.Close();
                    MessageBox.Show("Kaydınız TSK'ye İletilmiştir.", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = "";
                textBox2.Text = "";
                }       
        }
    }
}
