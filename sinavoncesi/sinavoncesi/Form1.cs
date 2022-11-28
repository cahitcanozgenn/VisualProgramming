using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinavoncesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            textBox1.Text = metin.ToUpper();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem=="MAVİ")
            {
                textBox2.ForeColor = Color.Blue;
            }
            else if(comboBox1.SelectedItem=="KIRMIZI")
            {
                textBox2.ForeColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Hatalı Seçim");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Copy();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox3.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                listBox1.Items.Add(radioButton1.Text);
            }
            else if(radioButton2.Checked==true)
            {
                listBox1.Items.Add(radioButton2.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowColor = true;
            font.MaxSize = 6;
            font.MaxSize = 60;
            font.ShowDialog();

            textBox5.Font = font.Font;
            textBox5.ForeColor = font.Color;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();

            textBox5.ForeColor = color.Color;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Kaydet";
            save.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Aç";
            open.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 2);
            pictureBox1.Image = ımageList1.Images[number];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Interval = 100;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value==progressBar1.Maximum)
            {
                progressBar1.Value = 1;
                progressBar2.Value = progressBar2.Value + 20;
            }
            else
            {
                progressBar1.Value = progressBar1.Value + 1;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("Kapatmak İstediğinizden Emin Misiniz? ","Mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if(result==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kapatmak İstediğinizden Emin Misiniz? ", "Mesaj", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            if (result == DialogResult.Abort)
            {
                Application.Exit();
            }
            else if(result==DialogResult.Retry)
            {
                Application.Exit();
            }
        }
    }
}
