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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileContent;
            using (StreamReader sr = new StreamReader("C:\\Users\\Administrator\\Desktop\\user.txt"))
            {
                fileContent = sr.ReadToEnd();
            }




            string line = fileContent.Split('\n')[0];
            string line2 = fileContent.Split('\n')[1];
            string line3 = fileContent.Split('\n')[2];

            string[] colon = line.Split(',,');
            string[] colon2 = line2.Split(',');

            MessageBox.Show(colon[0][0].ToString());
        }
    }
}
