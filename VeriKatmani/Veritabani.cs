using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciOtomasyon2021.VeriKatmani
{

    class Veritabani
    {
        public SqlConnection baglan = new SqlConnection("Data Source=localhost; Initial Catalog=OgrenciOtomasyon2021; User ID=alper; Password=12345;");

        public int DegisiklikGonder(string sorgu) //İnsert,update ve delete sorgularımız için fonk.
        { 
                int degisikliksayisi = 0;

                if (baglan.State != ConnectionState.Open)
                {
                    baglan.Open();
                }

                SqlCommand komut = baglan.CreateCommand();
                komut.CommandText = sorgu;
                degisikliksayisi = komut.ExecuteNonQuery();
                baglan.Close();
                return degisikliksayisi;

        }

        public string HucreGetir(string sorgu)// tek bir kayit dönmesinde kullanılacak fonk.
        {
            string gonder = "";
            try
            {
                if (baglan.State != ConnectionState.Open)
                {
                    baglan.Open();
                }
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglan;
                komut.CommandType = CommandType.Text;
                komut.CommandText = sorgu;
                gonder = komut.ExecuteScalar().ToString();
                baglan.Close();
            }
            catch (Exception e)
            {
                string gelenHata = e.Message;
                //log kaydı alınacak
            }
            return gonder;
        }

        public SqlDataReader multiReader(string sorgu) //Birden fazla deger donmesinde kullanılacak fonk.
        {
            if (baglan.State != ConnectionState.Open)
            {
                baglan.Open();
            }
            SqlCommand komut = baglan.CreateCommand();
            komut.CommandTimeout = 0;
            komut.CommandText = sorgu;

            SqlDataReader sqlreader = komut.ExecuteReader();
            // baglan.Close();
            return sqlreader;
        }

        public DataGridView griddoldur(string sorgu, string tablo, DataGridView dataGrid)
        {        
            if (baglan.State != ConnectionState.Open)
            {
                baglan.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds, tablo);
            dataGrid.DataSource = ds.Tables[tablo];
            baglan.Close();
            return dataGrid;
        }
    }
}

