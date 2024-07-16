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
    public partial class Form7 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.URL = "mixkit-sci-fi-click-900.WAV";
            Form3 HII = new Form3();
            HII.Show();
            Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
    }
}
