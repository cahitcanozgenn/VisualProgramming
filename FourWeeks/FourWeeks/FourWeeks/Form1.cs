using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourWeeks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text  +" "+ textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //int say = listBox1.Items.Count;
            //label3.Text = Convert.ToString(listBox1.Items.Count);
            MessageBox.Show(label3.Text = Convert.ToString(listBox1.Items.Count));

          
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string message = Interaction.InputBox("Adınızı Giriniz:", "Veri Alma");
            MessageBox.Show(message,"Gelen Mesaj");// (Mesaj,Pencere Başlığı)

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Uygulamayı kapatmaya eminmisin?",
 "Uygulama Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result1 == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                
            }
        }

        private void button7_Click(object sender, EventArgs e)
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

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            git:
            DialogResult result4 = MessageBox.Show("Mesaj", "Başlık",
MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Warning);
            if (result4 == DialogResult.Abort)
            {
                Application.Exit();
            }
            else if (result4 == DialogResult.Retry)
            {
                goto git;
            }
            else
            {

            }
        }
    }
}
