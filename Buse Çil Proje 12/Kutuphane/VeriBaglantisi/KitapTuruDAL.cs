using InterFaceler;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Varliklar;

namespace VeriBaglantisi
{
    public class KitapTuruDAL : VtIslemleriI<KitapTuru>
    {
        public void Ekle(KitapTuru kayit)
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                vt.Entry(kayit).State = EntityState.Added;
                vt.SaveChanges();
            }
        }

        public void Guncelle(KitapTuru kayit)
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                vt.Entry(kayit).State = EntityState.Modified;
                vt.SaveChanges();
            }
        }

        public void Sil(KitapTuru kayit)
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                vt.Entry(kayit).State = EntityState.Deleted;
                vt.SaveChanges();
            }
        }

        public List<KitapTuru> sorgula(Func<KitapTuru, bool> filtre)
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                return filtre == null ? vt.Set<KitapTuru>().ToList() : vt.Set<KitapTuru>().Where(filtre).ToList();
            }
        }

        public List<KitapTuru> tamaminiGetir()
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                return vt.Set<KitapTuru>().ToList();
            }
        }

        public KitapTuru tekilGetir(Func<KitapTuru, bool> filtre = null)
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                return vt.Set<KitapTuru>().SingleOrDefault(filtre);
            }
        }

        public KitapTuru tekilGetir(int ID)
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                return vt.Set<KitapTuru>().SingleOrDefault(o => o.KitapTuruID == ID);
            }
        }

        public void TopluEkle(List<KitapTuru> eklenecekListe)
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                foreach (KitapTuru Eleman in eklenecekListe)
                {
                    vt.Entry(Eleman).State = EntityState.Added;
                }

                vt.SaveChanges();
            }
        }

        public void TopluSil(List<KitapTuru> silinecekListe)
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                foreach (KitapTuru Eleman in silinecekListe)
                {
                    vt.Entry(Eleman).State = EntityState.Deleted;
                }

                vt.SaveChanges();
            }
        }
    }
}
