using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Cumhuriyet
{
    public partial class RSS_TekHaber : UserControl
    {
        public RSS_TekHaber()
        {
            InitializeComponent();
        }

        private void link_lbl_url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(link_lbl_url.Text);

        }

        private void pic_gorsel_Click(object sender, EventArgs e)
        {
            BuyukResim fr = new BuyukResim();
            fr.pictureBox1.Image = pic_gorsel.Image;
            fr.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbl_index_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Tarih_Click(object sender, EventArgs e)
        {

        }

        private void lbl_baslik_Click(object sender, EventArgs e)
        {

        }

        private void txt_aciklama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
