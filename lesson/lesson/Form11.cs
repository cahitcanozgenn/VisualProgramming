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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem=="RESİM 1")
            {
                pictureBox1.Image = ımageList1.Images[0];
            }
            else if(comboBox1.SelectedItem == "RESİM 2")
            {
                pictureBox1.Image = ımageList1.Images[1];
            }
            else if(comboBox1.SelectedItem == "RESİM 3")
            {
                pictureBox1.Image = ımageList1.Images[2];
            }
            else
            {
                MessageBox.Show("Hatalı Seçim");
            }
        }
    }
}
