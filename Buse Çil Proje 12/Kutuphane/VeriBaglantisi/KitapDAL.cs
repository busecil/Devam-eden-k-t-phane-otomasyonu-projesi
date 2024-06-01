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
    public class KitapDAL : VtIslemleriI<Kitap>
    {
        public void Ekle(Kitap kayit)
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                vt.Entry(kayit).State = EntityState.Added;
                vt.SaveChanges();
            }
        }

        public void Guncelle(Kitap kayit)
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                
                vt.Entry(kayit).State = EntityState.Modified;
                vt.SaveChanges();
            }
        }

        public void Sil(Kitap kayit)
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                vt.Entry(kayit).State = EntityState.Deleted;
                vt.SaveChanges();
            }
        }

        public List<Kitap> sorgula(Func<Kitap, bool> filtre)
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                return filtre == null ? vt.Set<Kitap>()
                        .Include(k => k.KitapTuru)
                        .Include(k => k.Yazar).ToList() : vt.Set<Kitap>()
                        .Include(k => k.KitapTuru)
                        .Include(k => k.Yazar)
                        .Where(filtre).ToList();
            }
        }

        public List<Kitap> tamaminiGetir()
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                var kitapListesi = vt.Set<Kitap>()
                        .Include(k => k.KitapTuru)
                        .Include(k => k.Yazar)
                       
                        .ToList();
                return kitapListesi;
            }
        }

        public Kitap tekilGetir(Func<Kitap, bool> filtre = null)
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                return vt.Set<Kitap>().SingleOrDefault(filtre);
            }
        }

        public Kitap tekilGetir(int ID)
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                return vt.Set<Kitap>().SingleOrDefault(o => o.KitapID == ID);
            }
        }

        public void TopluEkle(List<Kitap> eklenecekListe)
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                foreach (Kitap Eleman in eklenecekListe)
                {
                    vt.Entry(Eleman).State = EntityState.Added;
                }

                vt.SaveChanges();
            }
        }

        public void TopluSil(List<Kitap> silinecekListe)
        {
            using (KutuphaneContext vt = new KutuphaneContext())
            {
                foreach (Kitap Eleman in silinecekListe)
                {
                    vt.Entry(Eleman).State = EntityState.Deleted;
                }

                vt.SaveChanges();
            }
        }
    }
}
