using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = "123";
            string userName = "admin";
            string tuserName = textBox1.Text;
            string tpassword = textBox2.Text;

            if(tuserName==userName&&tpassword==password)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ya da Şifreniz Hatalıdır!!!!");
            }

                  
        }
    }
}
