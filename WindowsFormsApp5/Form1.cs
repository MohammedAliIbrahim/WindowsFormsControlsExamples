using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("طنطا");

            for (int i = 2000; i < 2020; i++ ){

                comboBox2.Items.Add(i.ToString());
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.majalisna.com/multimedia/408/208575-1275207271.wav");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.mp3quran.net/ar/husr");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show(comboBox2.SelectedItem.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {


            SoundPlayer simpleSound = new SoundPlayer("https://www.majalisna.com/multimedia/408/208575-1275207271.wav");
            simpleSound.Play();
            //WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            //wplayer.URL = "114.mp3";
            //wplayer.Controls.Play();
        }
    }
}
