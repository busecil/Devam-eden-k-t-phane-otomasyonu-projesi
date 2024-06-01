using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceler
{
    public interface VtIslemleriI<T>
    {
        void Ekle(T kayit);
        void Sil(T kayit);
        void Guncelle(T kayit);
        T tekilGetir(Func<T, bool> filtre = null);
        T tekilGetir(int ID);
        List<T> tamaminiGetir();
        List<T> sorgula(Func<T, bool> filtre);
        void TopluEkle(List<T> eklenecekListe);
        void TopluSil(List<T> silinecekListe);
    }
}
