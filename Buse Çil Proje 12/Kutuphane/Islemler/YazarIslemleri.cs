using InterFaceler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Varliklar;
using VeriBaglantisi;

namespace Islemler
{
    public class YazarIslemleri : VtIslemleriI<Yazar>
    {
        private YazarDAL yazarDAL; // Data Access Layyer  Veri Erişim KAtmannı

        public YazarIslemleri()
        {
            if (yazarDAL == null)
            {
                yazarDAL = new YazarDAL();
            }
        }

        public void Ekle(Yazar kayit)
        {
            yazarDAL.Ekle(kayit);
        }

        public void Guncelle(Yazar kayit)
        {
            yazarDAL.Guncelle(kayit);
        }

        public void Sil(Yazar kayit)
        {
            yazarDAL.Sil(kayit);
        }

        public List<Yazar> sorgula(Func<Yazar, bool> filtre)
        {
           return yazarDAL.sorgula(filtre);
        }

        public List<Yazar> tamaminiGetir()
        {
           return yazarDAL.tamaminiGetir();
        }

        public Yazar tekilGetir(Func<Yazar, bool> filtre = null)
        {
           return yazarDAL.tekilGetir(filtre);
        }

        public Yazar tekilGetir(int ID)
        {
            return yazarDAL.tekilGetir(ID);
        }

        public void TopluEkle(List<Yazar> eklenecekListe)
        {
            yazarDAL.TopluEkle(eklenecekListe);
        }

        public void TopluSil(List<Yazar> silinecekListe)
        {
            yazarDAL.TopluSil(silinecekListe);
        }
    }
}
