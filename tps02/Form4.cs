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
    public partial class Form4 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form4()
        {
            InitializeComponent();
            timer1.Start();
            player.controls.play();
            player.URL = "earthshine-121199.mp3";
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
                progressBar1.Value += 2;
            else
            {
                timer1.Stop();
                Form5 hii = new Form5();
                hii.Show();
                Hide();
                player.controls.stop();
            }

            if(progressBar1.Value<50)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else if(progressBar1.Value<100)
            {
                pictureBox1.Visible=false;
                pictureBox2.Visible = true;
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
        }
    }
}
