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
    public class YazarDAL : VtIslemleriI<Yazar>
    {
        public void Ekle(Yazar kayit)
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                vt.Entry(kayit).State = EntityState.Added;
                vt.SaveChanges();
            }
        }

        public void Guncelle(Yazar kayit)
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                vt.Entry(kayit).State = EntityState.Modified;
                vt.SaveChanges();
            }
        }

        public void Sil(Yazar kayit)
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                vt.Entry(kayit).State = EntityState.Deleted;
                vt.SaveChanges();
            }
        }

        public List<Yazar> sorgula(Func<Yazar, bool> filtre)
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                return filtre == null ? vt.Set<Yazar>().ToList() : vt.Set<Yazar>().Where(filtre).ToList();
            }
        }

        public List<Yazar> tamaminiGetir()
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                return vt.Set<Yazar>().ToList(); // select * from Yazar
            }
        }

        public Yazar tekilGetir(Func<Yazar, bool> filtre = null)
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                return vt.Set<Yazar>().SingleOrDefault(filtre);
            }
        }

        public Yazar tekilGetir(int ID)
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                return vt.Set<Yazar>().SingleOrDefault(o => o.YazarID == ID);
            }
        }

        public void TopluEkle(List<Yazar> eklenecekListe)
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                foreach (Yazar Eleman in eklenecekListe)
                {
                    vt.Entry(Eleman).State = EntityState.Added;
                }

                vt.SaveChanges();
            }
        }

        public void TopluSil(List<Yazar> silinecekListe)
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                foreach (Yazar Eleman in silinecekListe)
                {
                    vt.Entry(Eleman).State = EntityState.Deleted;
                }

                vt.SaveChanges();
            }
        }
    }
}
