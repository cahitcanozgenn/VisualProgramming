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

namespace Notebook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog(); 
            font.ShowColor = true;
            font.ShowDialog(); 
            font.MaxSize = 100; 
            font.MinSize = 5;
            richTextBox1.Font = font.Font;
            richTextBox1.ForeColor = font.Color;
        }

        private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            richTextBox1.ForeColor = color.Color;
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = true;
            save.CreatePrompt = true;
            save.InitialDirectory = "C:\\";
            save.Title = "Dosyalar";
            save.DefaultExt = "txt";
            save.Filter = "Metin dosyaları(*.txt)|*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter add = new StreamWriter(save.FileName);
                add.WriteLine(richTextBox1.Text);
                add.Close();
            }
        }
        OpenFileDialog open = new OpenFileDialog();
        string textKayit = "";
        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {


            open.Filter = "Metin Dosyaları (*.txt) |*.txt|Tüm Dosyalar|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader okur = new StreamReader(open.FileName, Encoding.Default);
                if (okur.EndOfStream)           //açılan dosyanın içi boş...
                    richTextBox1.Text = "";
                else                            //açılan dosyanın içi dolu
                    while (!okur.EndOfStream)
                    {
                        string text = okur.ReadToEnd();
                        richTextBox1.Text = text;
                    }
                textKayit = richTextBox1.Text;
                okur.Close();
                FileInfo dosyaBilgi = new FileInfo(open.FileName);
                this.Text = dosyaBilgi.Name + " - Cahit";
            }
        }

        private void klasörOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowDialog();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Cahit Can ÖZGEN");
        }

        private void yazıTipiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowDialog();
            richTextBox1.SelectionFont = font.Font;
          
        }

        private void yazıRengiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            richTextBox1.SelectionColor = color.Color;
        }
    }
}
