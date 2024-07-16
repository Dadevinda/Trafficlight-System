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
    
    public partial class Form6 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form6()
        {
            InitializeComponent();

            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           player.URL = "mixkit-sci-fi-click-900.WAV";
            Form3 hii = new Form3();
            hii.Show();
            Hide();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //label2.Visible = !label2.Visible;
            // label3.Visible = !label3.Visible;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Visible = !label2.Visible;
            label3.Visible = !label3.Visible;
        }
    }
}
