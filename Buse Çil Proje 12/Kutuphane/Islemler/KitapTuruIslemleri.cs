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
    public class KitapTuruIslemleri : VtIslemleriI<KitapTuru>
    {
        private KitapTuruDAL kitapTuruDAL;
        public KitapTuruIslemleri()
        {
            if (kitapTuruDAL == null)
            {
                kitapTuruDAL = new KitapTuruDAL();
            }
        }
        public void Ekle(KitapTuru kayit)
        {
            kitapTuruDAL.Ekle(kayit);
        }

        public void Guncelle(KitapTuru kayit)
        {
            kitapTuruDAL.Guncelle(kayit);
        }

        public void Sil(KitapTuru kayit)
        {
            kitapTuruDAL.Sil(kayit);
        }

        public List<KitapTuru> sorgula(Func<KitapTuru, bool> filtre)
        {
            return kitapTuruDAL.sorgula(filtre);
        }

        public List<KitapTuru> tamaminiGetir()
        {
            return kitapTuruDAL.tamaminiGetir();
        }

        public KitapTuru tekilGetir(Func<KitapTuru, bool> filtre = null)
        {
            return kitapTuruDAL.tekilGetir(filtre);
        }

        public KitapTuru tekilGetir(int ID)
        {
            return kitapTuruDAL.tekilGetir(ID);
        }

        public void TopluEkle(List<KitapTuru> eklenecekListe)
        {
            kitapTuruDAL.TopluEkle(eklenecekListe);
        }

        public void TopluSil(List<KitapTuru> silinecekListe)
        {
            kitapTuruDAL.TopluSil(silinecekListe);
        }
    }
}
