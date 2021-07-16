using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciOtomasyon2021.IsKatmani
{
    class KullaniciIslem
    {

        public string kullaniciAdOlustur(string ad, string soyad)
        {
            string kullaniciAd;
            kullaniciAd = String.Concat(ad[0], soyad);
            return kullaniciAd;
        }


    }
}
