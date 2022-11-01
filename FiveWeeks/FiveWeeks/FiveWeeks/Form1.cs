using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveWeeks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Uygulamayı Kapatmak İstiyor Musun?", "Sistem Mesajı", MessageBoxButtons.YesNoCancel);
            if (result2 == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result2 == DialogResult.No)
            {
                MessageBox.Show("Uygulama Kapatılmadı.");
            }
            else if (result2 == DialogResult.Cancel)
            {
                MessageBox.Show("Hiçbir Şey Yapılmadı");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Dosya Seçiniz"; // üst kısım
            openFileDialog1.InitialDirectory = "C:\\"; // dizin
            openFileDialog1.ShowDialog(); // diyoloğun açılması
            textBox1.Text = openFileDialog1.FileName;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog(); // yeni bir nesne oluşturuldu.
            save.Title = "Dosya Kaydet"; // üst kısım.
            save.ShowDialog(); // diyalog gösterildi.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            label1.ForeColor = color.Color;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            this.BackColor = color.Color;
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog(); // diyalog gösterildi.
            textBox2.Text = folderBrowserDialog1.SelectedPath; // dosya yolu textboxa aktarıldı.
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowColor = true; // renk özelliği aktif edildi.
            font.ShowDialog(); // dialog gösterildi.
            font.MaxSize = 50; // maximum yazı boyutu 50 yapıldı.
            font.MinSize = 15; // minimum yazı boyutu 15 yapıldı.
            label2.Font = font.Font;
            label2.ForeColor = font.Color;
        }
    }
}
