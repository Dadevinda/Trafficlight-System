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
    public partial class Form5 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form5()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();

            
               
              
            


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
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




            if (r4.Visible == true)
            {
                r4.Visible = false;
                y7.Visible = true;
                g4.Visible = false;
                y8.Visible = false;
            }
            else if (y7.Visible == true)
            {
                y7.Visible = false;
                g4.Visible = true;
                r4.Visible = false;
                y8.Visible = false;
            }
            else if (g4.Visible == true)
            {
                y7.Visible = false;
                y8.Visible = true;
                r4.Visible = false;
                g4.Visible = false;
            }
            else if (y8.Visible == true)
            {
                y8.Visible = false;
                r4.Visible = true;
                g4.Visible = false;
                y7.Visible = false;
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


            if (g3.Visible == true)
            {
                g3.Visible = false;
                y5.Visible = true;
                r3.Visible = false;
                y6.Visible = false;
            }
            else if (y5.Visible == true)
            {
                y5.Visible = false;
                r3.Visible = true;
                y6.Visible = false;
                g3.Visible = false;
            }
            else if (r3.Visible == true)
            {
                y5.Visible = false;
                y6.Visible = true;
                r3.Visible = false;
                g3.Visible = false;
            }
            else if (y6.Visible == true)
            {
                y6.Visible = false;
                g3.Visible = true;
                r3.Visible = false;
                y5.Visible = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

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


            textBox3.Text = (Int32.Parse(textBox3.Text) + 1).ToString();
            if (textBox3.Text == "11")
                textBox3.Text = "1";

            int c = Int32.Parse(textBox3.Text);

            if (g3.Visible == true && c <= 5)
            {
                dl1.Visible = false;
                dl2.Visible = true;
                dl3.Visible = false;
            }
            else if (g3.Visible == true && c >= 5)
            {
                dl1.Visible = false;
                dl2.Visible = false;
                dl3.Visible = true;
            }
            else
            {
                dl3.Visible = false;
                dl2.Visible = false;
                dl1.Visible = true;
            }




           textBox4.Text = (Int32.Parse(textBox4.Text) + 1).ToString();
            if (textBox4.Text == "11")
                textBox4.Text = "1";

            int d = Int32.Parse(textBox4.Text);

            if (g4.Visible == true && d <= 5)
            {
                dr1.Visible = false;
                dr2.Visible = true;
                dr3.Visible = false;
            }
            else if (g4.Visible == true && d >= 5)
            {
                dr1.Visible = false;
                dr2.Visible = false;
                dr3.Visible = true;
            }
            else
            {
                dr3.Visible = false;
                dr2.Visible = false;
                dr1.Visible = true;
            }

            textBox5.Text = (Int32.Parse(textBox5.Text) + 1).ToString();
            


            if(g2.Visible== true && ur2.Visible==true)
            {
                cwr1.Visible=true;
                cwr2.Visible = false;
                cwl1.Visible = true;
                cwl2.Visible = false;
            }
            else
            {
                cwr2.Visible = true;
                cwr1.Visible = false;
                cwl1.Visible = false;
                cwl2.Visible = true;
            }


        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            int g = Int32.Parse(textBox5.Text);

            if (g1.Visible == true && g <= 25)

            {
                c1.Visible = true;
                c1.Left += 20;
                c2.Visible = false;

                c3.Visible = true;
                c3.Left -= 20;
                c4.Visible = false;

                train.Visible = true;
                train.Left += 60;

                trg1.Visible = true;
                trg3.Visible = true;
                
          

            }
            else if (g1.Visible == true && g <= 30)
            {
                c1.Visible = false;
                c2.Visible = true;
                c2.Top -= 30;

                c3.Visible = false;
                c4.Visible = true;
                c4.Top += 30;

                trg1.Visible = false;
                trg3.Visible = false;
            }

            if (g2.Visible == true && g <= 4)
            {
                c8.Visible = true;
                c8.Top += 30;
                train2.Left += 20;
                trg1.Visible = true;
                trg3.Visible=true;

               
              
            }
            else if (6 <= g && g <= 8)
            {
                train2.Left += 20;
               trg1.Visible= true;
                trg3.Visible= true;
               
            }
            else if (9 <= g && g <= 16)
            {
                train2.Left += 20;
                c8.Top += 30;
                trg1.Visible = false;
                trg3.Visible = false;
            }

            if (g <= 65 && g >= 60)
            {
                c5.Visible = true;
                c5.Left += 25;
                c6.Visible = true;
                c6.Left -= 18;
                
              
            }
            else if (g <= 72 && g >= 65)
            {
                c5.Left += 30;
                c7.Visible = true;
                c7.Top += 30;
                c6.Visible = false;
                c10.Visible = true;
                c10.Left += 50;
               
                
            }
            if(g==20)
                player.URL = "A9002 Ringtone.mp3";
            if(g==1)
                player.URL = "A9002 Ringtone.mp3";
            if(g==61)
                player.URL = "Police Siren Sound Effect.mp3";
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void y7_Click(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox5.Text);
            if (a == 30)
            {
                player.URL = "helicopter-fly-over-01.mp3";
            }
            if (a >= 30)
            {       h1.Left -= 10;
            h1.Visible = true;
            }

            if (a >= 40)
            {
                p1.Visible = true;
                p1.Left += 5;
            }
            if(a>=45)
            {
                p2.Visible = true;
                p2.Left += 3;
            }
            if(a>50)
            {
                p3.Visible = true;
                p3.Left += 5;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            { 
                l2.Visible=true;
                l4.Visible=true;
                l6.Visible=true;
                l8.Visible=true;

                l1.Visible=false;
                l3.Visible=false;
                l5.Visible=false;
                l7.Visible=false;
            }
            else
            {

                l1.Visible = true;
                l3.Visible = true;
                l5.Visible = true;
                l7.Visible = true;

                l2.Visible = false;
                l4.Visible = false;
                l6.Visible = false;
                l8.Visible = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 hii = new Form3();
            hii.Show();
            Hide();
            player.URL = "mixkit-sci-fi-click-900.WAV";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void y1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
