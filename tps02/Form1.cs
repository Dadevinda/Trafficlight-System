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
    public partial class Form1 : Form
    {
     WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            player.controls.play();
            player.URL = "stranger-things-124008.mp3";
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Enter(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Visible = !label1.Visible;
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 hii = new Form2();
            hii.Show();
            Hide();
            player.controls.stop();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            player.URL = "mixkit-sci-fi-click-900.WAV";
        }
    }
}
