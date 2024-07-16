using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace tps02
{
    public partial class Form8 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form8()
        {
            InitializeComponent();

            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (r1.Visible == true)
            {
                r1.Visible = false;
                y1.Visible = true;
                g1.Visible = false;
                y2.Visible = false;
            }
            else if (y1.Visible == true)
            {
                y1.Visible = false;
                g1.Visible = true;
                r1.Visible = false;
                y2.Visible = false;
            }
            else if (g1.Visible == true)
            {
                y1.Visible = false;
                y2.Visible = true;
                r1.Visible = false;
                g1.Visible = false;
            }
            else if (y2.Visible == true)
            {
                y1.Visible = false;
                r1.Visible = true;
                g1.Visible = false;
                y2.Visible = false;
            }




            if (g2.Visible == true)
            {
                g2.Visible = false;
                y3.Visible = true;
                r2.Visible = false;
                y4.Visible = false;
            }
            else if (y3.Visible == true)
            {
                y3.Visible = false;
                r2.Visible = true;
                y4.Visible = false;
                g2.Visible = false;
            }
            else if (r2.Visible == true)
            {
                y3.Visible = false;
                y4.Visible = true;
                r2.Visible = false;
                g2.Visible = false;
            }
            else if (y4.Visible == true)
            {
                y4.Visible = false;
                g2.Visible = true;
                r2.Visible = false;
                y3.Visible = false;

            }
        }

            private void timer2_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (Int32.Parse(textBox1.Text) + 1).ToString();
            if (textBox1.Text == "11")
                textBox1.Text = "1";

            int b = Int32.Parse(textBox1.Text);

            if (g1.Visible == true && b <= 5)
            {
                ul1.Visible = false;
                ul2.Visible = true;
                ul3.Visible = false;
            }
            else if (g1.Visible == true && b >= 5)
            {
                ul1.Visible = false;
                ul2.Visible = false;
                ul3.Visible = true;
            }
            else
            {
                ul3.Visible = false;
                ul2.Visible = false;
                ul1.Visible = true;
            }
           
            
            
            textBox2.Text = (Int32.Parse(textBox2.Text) + 1).ToString();
            if (textBox2.Text == "11")
                textBox2.Text = "1";

            int a = Int32.Parse(textBox2.Text);

            if (g2.Visible == true && a <= 5)
            {
                ur1.Visible = false;
                ur2.Visible = true;
                ur3.Visible = false;
            }
            else if (g2.Visible == true && a >= 5)
            {
                ur1.Visible = false;
                ur2.Visible = false;
                ur3.Visible = true;
            }
            else
            {
                ur3.Visible = false;
                ur2.Visible = false;
                ur1.Visible = true;
            }


            
            if (g2.Visible == true && ur2.Visible == true)
            {
                cwr2.Visible = true;
                cwr1.Visible = false;
                cwl2.Visible = true;
                cwl1.Visible = false;
            }
            else
            {
                cwr1.Visible = true;
                cwr2.Visible = false;
                cwl2.Visible = false;
                cwl1.Visible = true;
            }
        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void key_down(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c1.Top-= 20;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            c1.Left-=20;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c1.Left += 20;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c1.Top += 20;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            player.URL = "mixkit-sci-fi-click-900.WAV";
            Form3 HII = new Form3();
            HII.Show();
            Hide();
        }
    }
}
