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
    public partial class YoneticiForm : Form
    {
        public YoneticiForm()
        {
            InitializeComponent();
        }

        private void YoneticiForm_Load(object sender, EventArgs e)
        {

        }

        private void YoneticiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisForm giris = new GirisForm();
            giris.Show();


        }

        private void btn_personelBilgi_Click(object sender, EventArgs e)
        {
            UygulamaKatmani.YoneticiBilgi yoneticiBilgi = new YoneticiBilgi();
            yoneticiBilgi.Show();

        }

        private void btn_dersOlusturma_Click(object sender, EventArgs e)
        {
            UygulamaKatmani.YoneticiDersIslemleri yoneticiDers = new YoneticiDersIslemleri();
            yoneticiDers.Show();
        }

        private void btn_kullaniciIslemleri_Click(object sender, EventArgs e)
        {
            UygulamaKatmani.YoneticiKullanici yoneticiKullanici = new YoneticiKullanici();
            yoneticiKullanici.Show();
        }
    }
}
