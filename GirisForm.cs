using OgrenciOtomasyon2021.UygulamaKatmani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciOtomasyon2021
{
    public partial class GirisForm : Form
    {
        
        public GirisForm()
        {
            InitializeComponent();
        }
        
        public static string kullaniciID;
        public static string kullaniciYETKI;
        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
                VeriKatmani.Veritabani veritabani = new VeriKatmani.Veritabani();
                string sorgu = "Select kullanici_id from Kullanici_tbl where kullanici_ad='" + txt_kullaniciGiris.Text + "'and kullanici_sifre='" + txt_kullaniciSifre.Text + "'";
                kullaniciID = veritabani.HucreGetir(sorgu);
                string sorgu2 = "Select yetki from Kullanici_tbl where kullanici_id='" + kullaniciID + "'";
                kullaniciYETKI = veritabani.HucreGetir(sorgu2);

            
                if (kullaniciID != "")
                {
                    if (kullaniciYETKI == "ogrenci")
                    {
                        UygulamaKatmani.OgrenciForm ogrenciForm = new UygulamaKatmani.OgrenciForm();
                        this.Hide();
                        ogrenciForm.Show();
                        /*if (ogrenciForm.Enabled == false)
                        {
                            this.Show();
                        }*/
                    }
                    else if (kullaniciYETKI == "ogrUye")
                    {
                        UygulamaKatmani.OgretimUyeForm ogretimUye = new OgretimUyeForm();
                        this.Hide();
                        ogretimUye.Show();

                    }
                    else if (kullaniciYETKI == "kullanici")
                    {

                    }
                    else if (kullaniciYETKI == "yonetici")
                    {
                        UygulamaKatmani.YoneticiForm yoneticiForm = new YoneticiForm();
                        this.Hide();
                        yoneticiForm.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifreyi yanlış girdiniz!");
                    txt_kullaniciGiris.Text = "";
                    txt_kullaniciSifre.Text = "";
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.ToString());
            }

        }

        private void btn_giris_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void btn_giris_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void GirisForm_Load(object sender, EventArgs e)
        {

        }

        private void txt_kullaniciSifre_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
