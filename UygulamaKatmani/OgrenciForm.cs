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
    public partial class OgrenciForm : Form
    {
        public OgrenciForm()
        {
            InitializeComponent();
        }

        private void btn_ogrenciBilgi_Click(object sender, EventArgs e)
        {
            UygulamaKatmani.OgrenciBilgiForm ogrenciBilgiForm = new UygulamaKatmani.OgrenciBilgiForm();

            if (Application.OpenForms["OgrenciBilgiForm"] == null)
            {
                ogrenciBilgiForm.Show();
            }

        }

        private void btn_ogrenciSecilenDers_Click(object sender, EventArgs e)
        {
            UygulamaKatmani.OgrenciSecilenDerslerForm ogrenciSecilenDersler = new UygulamaKatmani.OgrenciSecilenDerslerForm();
            ogrenciSecilenDersler.Show();
        }

        private void btn_ogrenciDerseYazilma_Click(object sender, EventArgs e)
        {
            UygulamaKatmani.OgrenciDerseYazilmaForm derseYazilmaForm = new UygulamaKatmani.OgrenciDerseYazilmaForm();
            derseYazilmaForm.Show();
        }

        private void btn_ogrenciDersProgram_Click(object sender, EventArgs e)
        {
            UygulamaKatmani.OgrenciDersProgram ogrenciDersProgram = new UygulamaKatmani.OgrenciDersProgram();
            ogrenciDersProgram.Show();
        }

        private void OgrenciForm_Load(object sender, EventArgs e)
        {

        }

        private void OgrenciForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisForm giris = new GirisForm();
            giris.Show();
        }
    }
}
