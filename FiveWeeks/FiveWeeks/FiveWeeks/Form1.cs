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
    }
}
