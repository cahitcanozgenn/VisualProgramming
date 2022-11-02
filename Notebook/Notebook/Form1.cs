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
            textBox1.Font = font.Font;
            textBox1.ForeColor = font.Color;
        }

        private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            textBox1.ForeColor = color.Color;
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
                add.WriteLine(textBox1.Text);
                add.Close();
            }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(file.FileName);
                if (fi.Exists)
                {
                    System.Diagnostics.Process.Start(file.FileName);
                }
                else 
                {
                   //
                }
            }
        }

        private void klasörOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowDialog();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
            textBox1.Clear();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = Clipboard.GetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Cahit Can ÖZGEN");
        }
    }
}
