using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void fontDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowColor = true;
            font.ShowDialog();
            textBox1.Font = font.Font;
            textBox1.ForeColor = font.Color;
        }

        private void colorDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            textBox1.ForeColor = color.Color;
        }

        private void savaFileDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Dosya Kaydetme";
            save.ShowDialog();
        }

        private void openFileDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileDialog1.Title = "Dosya Açınız";
            openFileDialog1.ShowDialog();
        }
    }
}
