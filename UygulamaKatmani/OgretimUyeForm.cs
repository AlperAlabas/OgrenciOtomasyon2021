using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciOtomasyon2021.UygulamaKatmani
{
    public partial class OgretimUyeForm : Form
    {
        public OgretimUyeForm()
        {
            InitializeComponent();
        }

        private void btn_ogrUyeBilgi_Click(object sender, EventArgs e)
        {
            UygulamaKatmani.OgretimUyeBilgiForm ogretimUyeBilgi = new OgretimUyeBilgiForm();
            ogretimUyeBilgi.Show();
        }

        private void btn_ogrUyeSecilenDers_Click(object sender, EventArgs e)
        {
            UygulamaKatmani.OgretimUyeSecilenDerslerForm ogretimUyeSecilenDersler = new OgretimUyeSecilenDerslerForm();
            ogretimUyeSecilenDersler.Show();
        }

        private void btn_ogrUyeDersProgram_Click(object sender, EventArgs e)
        {
            UygulamaKatmani.OgretimUyeDersProgram ogretimUyeDersProgram = new OgretimUyeDersProgram();
            ogretimUyeDersProgram.Show();
        }

        private void btn_ogrUyeDanismanlik_Click(object sender, EventArgs e)
        {
            UygulamaKatmani.OgretimUyeDanismanlikForm ogretimUyeDanismanlik = new OgretimUyeDanismanlikForm();
            ogretimUyeDanismanlik.Show();
        }

        private void btn_ogrUyeNot_Click(object sender, EventArgs e)
        {
            UygulamaKatmani.OgretimUyeNot ogretimUyeNot = new OgretimUyeNot();
            ogretimUyeNot.Show();
        }

        private void OgretimUyeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisForm giris = new GirisForm();
            giris.Show();
        }
    }
}
