using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int asansorDegeri = 0, gidilecekKatDegeri, a, asansorYDegeri, gidilecekYDegeri;
        private void button1_Click(object sender, EventArgs e)
        {
            gidilecekKatDegeri = 0;
            gidilecekYDegeri = 345;
            a = asansorDegeri - gidilecekKatDegeri;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gidilecekKatDegeri = 2;
            gidilecekYDegeri = 111;
            a = asansorDegeri - gidilecekKatDegeri;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gidilecekKatDegeri = 1;
            gidilecekYDegeri = 228;
            a = asansorDegeri - gidilecekKatDegeri;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gidilecekKatDegeri = 3;
            gidilecekYDegeri = -6;
            a = asansorDegeri - gidilecekKatDegeri;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            asansorYDegeri = pictureBox1.Location.Y;
            if (a == 0)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                timer1.Interval = 25;
                timer1.Stop();
            }


            else if (a < 0)
            {
                if (asansorYDegeri - gidilecekYDegeri == 0)
                {
                    asansorDegeri = gidilecekKatDegeri;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;

                    timer1.Interval = 20;

                    if (asansorDegeri == gidilecekYDegeri)
                    {
                        timer1.Stop();
                    }
                }
                else
                {
                    if (asansorYDegeri - gidilecekYDegeri < 25)
                    {
                        timer1.Interval = 50;
                    }
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 1);

                }

            }

            else if (a > 0)
            {
                if (asansorYDegeri - gidilecekYDegeri == 0)
                {
                    asansorDegeri = gidilecekKatDegeri;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    timer1.Interval = 100;
                    timer1.Stop();
                }
                else
                {
                    if (gidilecekYDegeri - asansorYDegeri < 25)
                    {
                        timer1.Interval = 50;
                    }
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 1);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            timer1.Interval = 20;
            timer2.Interval = 100;

        }
    }
}
