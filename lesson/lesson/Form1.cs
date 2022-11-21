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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = "admin";
            string password = "1234";
            string tuserName = textBox1.Text;
            string tpassword = textBox2.Text;
            if(tuserName==userName&&password==tpassword)
            {
                Form2 alfa = new Form2();
                alfa.Show();
                this.Hide();
            }
            else
            {
                DialogResult result1 = MessageBox.Show("Kullanıcı Adı ya da Şifreniz Hatalıdır.",
  "Uygulama Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result1 == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {

                }
            }
        }
    }
}
