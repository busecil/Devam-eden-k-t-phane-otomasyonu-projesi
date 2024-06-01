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
    public class KitapIslemleri : VtIslemleriI<Kitap>
    {
        private KitapDAL kitapDAL;

        public KitapIslemleri()
        {
            if (kitapDAL == null)
            {
                kitapDAL = new KitapDAL();
            }
        }
        public void Ekle(Kitap kayit)
        {
            kitapDAL.Ekle(kayit);
        }

        public void Guncelle(Kitap kayit)
        {
           kitapDAL.Guncelle(kayit);
        }

        public void Sil(Kitap kayit)
        {
            kitapDAL.Sil(kayit);
        }

        public List<Kitap> sorgula(Func<Kitap, bool> filtre)
        {
           return kitapDAL.sorgula(filtre);
        }

        public List<Kitap> tamaminiGetir()
        {
          return kitapDAL.tamaminiGetir();  
        }

        public Kitap tekilGetir(Func<Kitap, bool> filtre = null)
        {
           return kitapDAL.tekilGetir(filtre);   
        }

        public Kitap tekilGetir(int ID)
        {
            return kitapDAL.tekilGetir(ID);
        }

        public void TopluEkle(List<Kitap> eklenecekListe)
        {
            kitapDAL.TopluEkle(eklenecekListe); 
        }

        public void TopluSil(List<Kitap> silinecekListe)
        {
            kitapDAL.TopluSil(silinecekListe);
        }
    }
}
