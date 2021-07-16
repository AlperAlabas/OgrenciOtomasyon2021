using ADGV;
using OgrenciOtomasyon2021.VeriKatmani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciOtomasyon2021.UygulamaKatmani
{
    public partial class YoneticiKullanici : Form
    {
        VeriKatmani.Veritabani veritabani = new Veritabani();
        IsKatmani.KullaniciIslem kullanici = new IsKatmani.KullaniciIslem();
        string bolumID;
        string adresID;
        string kullaniciID;
        string viewSorguUye = "select * from Ogruye_tbl";
        string viewTabloUye = "Ogruye_tbl";
        string viewSorguOgrenci = "select * from Ogrenci_tbl";
        string viewTabloOgrenci = "Ogrenci_tbl";
        string viewSorguPersonel = "select * from Personel_tbl";
        string viewTabloPersonel = "Personel_tbl";
        private string dosyaID;

        public YoneticiKullanici()
        {
            InitializeComponent();
        }

        public static implicit operator YoneticiKullanici(YoneticiDersIslemleri v)
        {
            throw new NotImplementedException();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab.Text== "Öğretim Üye İşlemleri")
            {
                

            }
            if (tabControl1.SelectedTab.Text == "Personel İşlemleri")
            {
                

            }
            if (tabControl1.SelectedTab.Text == "Danışmanlık İşlemleri")
            {
               

            }
        }

        private void YoneticiKullanici_Load(object sender, EventArgs e)
        {
            
            //MessageBox.Show("personel");
            string fakulteSorgu = "select fakulte_ad from Fakulte_tbl";
            SqlDataReader dr1 = veritabani.multiReader(fakulteSorgu);
            while (dr1.Read())
            {
                cmb_ogrenciFakulte.Items.Add(dr1["fakulte_ad"]);
                cmb_ogrUyeFakulte.Items.Add(dr1["fakulte_ad"]);
                cmb_PersonelFakulte.Items.Add(dr1["fakulte_ad"]);
            }
            dr1.Close();
            gridDoldur(adgv_ogrUye,viewSorguUye,viewTabloUye);
            gridDoldur(danismanlikADGV, viewSorguOgrenci, viewTabloOgrenci);
            gridDoldur(adgv_personel, viewSorguPersonel, viewTabloPersonel);
        }

        private void cmb_ogrenciFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fakulte = cmb_ogrenciFakulte.SelectedItem.ToString();
            //MessageBox.Show(fakulte);
            string fakulteSorgu = "select bolum_ad from Bolum_tbl where fakulte_id = (select fakulte_id from Fakulte_tbl where fakulte_ad = '"+fakulte+"')";
            SqlDataReader dr1 = veritabani.multiReader(fakulteSorgu);
            while (dr1.Read())
            {
                cmb_ogrenciBolum.Items.Add(dr1["bolum_ad"]);
                
            }
            dr1.Close();
        }

        private void cmb_ogrUyeFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fakulte = cmb_ogrUyeFakulte.SelectedItem.ToString();
            //MessageBox.Show(fakulte);
            string fakulteSorgu = "select bolum_ad from Bolum_tbl where fakulte_id = (select fakulte_id from Fakulte_tbl where fakulte_ad = '" + fakulte + "')";
            SqlDataReader dr1 = veritabani.multiReader(fakulteSorgu);
            while (dr1.Read())
            {
                cmb_ogrUyeBolum.Items.Add(dr1["bolum_ad"]);

            }
            dr1.Close();
        }

        private void btn_danismanOgrenciEkle_Click(object sender, EventArgs e)
        {
            string nickname = kullanici.kullaniciAdOlustur(txt_ogrenciAd.Text, txt_ogrenciSoyad.Text);
            //MessageBox.Show(nickname);
            string Ekle = "insert into Kullanici_tbl values('" + nickname + "','" + new Random().Next(0, 999999) + "','ogrenci')";
            int kontrol=veritabani.DegisiklikGonder(Ekle);
            if (kontrol!=0)
            {
                MessageBox.Show("Kullanıcı Kaydedildi.");
            }
            else
            {
                MessageBox.Show("HATA : Kullanıcı Kaydedilemedi.");
            }

            #region adres bilgileri
            string il = cmb_ogrenciIl.SelectedItem.ToString();
            string ilce = txt_ogrenciIlce.Text;
            string PK = txt_ogrenciPK.Text;
            string sabitTel = txt_ogrenciSabittel.Text;
            string cepTel = txt_ogrenciCeptel.Text;
            string fax = txt_ogrenciFax.Text;
            string mail = txt_ogrenciMail.Text;
            string adres = txt_ogrenciAdres.Text;
            #endregion

            string AdresEkle = "insert into Adres_tbl values('" + il + "','" + ilce + "','" + PK + "','" + sabitTel + "','" + cepTel + "','" + fax + "','" + mail + "','" + adres + "')";
            int kontrolAdres = veritabani.DegisiklikGonder(AdresEkle);
        }

        private void btn_OgrUyeEkle_Click(object sender, EventArgs e)
        {
            string nickname = kullanici.kullaniciAdOlustur(txt_ogrUyeAd.Text, txt_ogrUyeSoyad.Text);
            //MessageBox.Show(nickname);
            string Ekle = "insert into Kullanici_tbl values('" + nickname + "','" + new Random().Next(0, 999999) + "','ogrUye')";
            int kontrol = veritabani.DegisiklikGonder(Ekle);
            string kullaniciIDSorgu = "select max(kullanici_id) from Kullanici_tbl";
            if (kontrol != 0)
            {
                MessageBox.Show("Kullanıcı Kaydedildi.");
            }
            else
            {
                MessageBox.Show("HATA : Kullanıcı Kaydedilemedi.");
            }
            kullaniciID = veritabani.HucreGetir(kullaniciIDSorgu);
            #region adres bilgileri
            string il = cmb_ogrUyeIl.SelectedItem.ToString();
            string ilce = txt_ogrUyeIlce.Text;
            string PK = txt_ogrUyePK.Text;
            string sabitTel = txt_ogrUyeSabitTel.Text;
            string cepTel = txt_ogrUyeCepTel.Text;
            string fax = txt_ogrUyeFax.Text;
            string mail = txt_ogrUyeMail.Text;
            string adres = txt_ogrUyeAdres.Text;
            #endregion

            string AdresEkle = "insert into Adres_tbl values('" + il + "','" + ilce + "','" + PK + "','" + sabitTel + "','" + cepTel + "','" + fax + "','" + mail + "','" + adres + "')";
            string adresIDSorgu = "select max(adres_id) from Adres_tbl";
            int kontrolAdres = veritabani.DegisiklikGonder(AdresEkle);
            if (kontrolAdres != 0)
            {
                MessageBox.Show("Adres Kaydedildi.");
            }
            else
            {
                MessageBox.Show("HATA : Adres Kaydedilemedi.");
            }
            adresID = veritabani.HucreGetir(adresIDSorgu);

            #region ogrUYe Bilgileri
            string sicil = txt_ogrUyeSicilNo.Text;
            string tc = txt_ogrUyeTc.Text;
            string ad = txt_ogrUyeAd.Text;
            string soyad = txt_ogrUyeSoyad.Text;
            string bolumNo = bolumID;
            string kullaniciNo = kullaniciID;
            string adresNo = adresID;

            #endregion

            string ogrUyeSorgu = "insert into Ogruye_tbl values('" + sicil + "','" + tc + "','" + ad + "','" + soyad + "','" + bolumNo + "','" + adresNo + "','" + kullaniciNo + "')";
            int ogrUyeEkle = veritabani.DegisiklikGonder(ogrUyeSorgu);
            if (ogrUyeEkle != 0)
            {
                MessageBox.Show("Uye Kaydedildi.");
            }
            else
            {
                MessageBox.Show("HATA : Uye Kaydedilemedi.");
            }

        }

        private void cmb_ogrUyeBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Sorgu = "select bolum_id from Bolum_tbl where bolum_ad='"+cmb_ogrUyeBolum.SelectedItem.ToString()+"'";
            bolumID = veritabani.HucreGetir(Sorgu);
        }

        private void gridDoldur(AdvancedDataGridView DGrid,string sorgu,string table)
        {
            
            veritabani.griddoldur(sorgu, table, DGrid);
        }

        private void adgv_ogrUye_FilterStringChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = adgv_ogrUye.DataSource;
            bs.Filter = adgv_ogrUye.FilterString;
        }

        private void danismanlikADGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void adgv_ogrUye_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dosyaID = adgv_ogrUye.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_ogrUyeSicilNo.Text = adgv_ogrUye.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_ogrUyeTc.Text = adgv_ogrUye.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_ogrUyeAd.Text = adgv_ogrUye.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_ogrUyeSoyad.Text = adgv_ogrUye.Rows[e.RowIndex].Cells[4].Value.ToString();
            bolumID = adgv_ogrUye.Rows[e.RowIndex].Cells[5].Value.ToString();
            adresID = adgv_ogrUye.Rows[e.RowIndex].Cells[6].Value.ToString();

            string bolumYaz="select bolum_ad from Bolum_tbl where bolum_id='"+bolumID+"'";
            cmb_ogrUyeBolum.Text = veritabani.HucreGetir(bolumYaz);
            string fakulteBul = "select fakulte_id from Bolum_tbl where bolum_id='" + bolumID + "'";
            string fakulteID = veritabani.HucreGetir(fakulteBul);
            string fakulteYaz = "select fakulte_ad from Fakulte_tbl where fakulte_id='" + fakulteID + "'";
            cmb_ogrUyeFakulte.Text = veritabani.HucreGetir(fakulteYaz);

            #region adres bilgileri
            string il = veritabani.HucreGetir("select");
            string ilce;
            string PK;
            string sabitTel;
            string cepTel;
            string fax;
            string mail;
            string adres; 
            #endregion

            
            
            



            MessageBox.Show(dosyaID);
        }
    }
}
