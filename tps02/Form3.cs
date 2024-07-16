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
    public partial class Form3 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form3()
        {
            InitializeComponent();
            player.controls.play();
            player.URL = "epic_battle_music_1-6275.mp3";
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            Form4 hii = new Form4();
            hii.Show();
            Hide();
            player.URL = "mixkit-sci-fi-click-900.WAV";
           
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            player.URL = "mixkit-sci-fi-click-900.WAV";
            Form6 hii = new Form6();
            hii.Show();
            Hide ();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            player.URL = "mixkit-sci-fi-click-900.WAV";
            Form1 hii = new Form1();
            hii.Show ();
            Hide ();
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            player.URL = "mixkit-sci-fi-click-900.WAV";
            Hide ();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            player.URL = "mixkit-sci-fi-click-900.WAV";
            Form7 HII = new Form7();
            HII.Show();
            Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            player.URL = "mixkit-sci-fi-click-900.WAV";
            Form8 hii = new Form8();
            hii.Show();
            Hide();
        }
    }
}
