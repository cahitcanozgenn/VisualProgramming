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

namespace NestedLoop
{
    public partial class Form2 : Form
    {
        public static string Read()
        {
            string fileContent;
            StreamReader sr = new StreamReader("C:\\Users\\Administrator\\Desktop\\user.txt");
            fileContent = sr.ReadToEnd();
            return fileContent;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Read());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            StreamReader reader = new StreamReader("C:\\Users\\Administrator\\Desktop\\user.txt");
            string text = reader.ReadToEnd();
            string[] lines = text.Split('\n');
            int lineCount = lines.Length;
            MessageBox.Show(lineCount.ToString());
        }
    }
}
