using Islemler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Varliklar;
using VeriBaglantisi;

namespace Kutuphane.Formlar
{
    public partial class KitapIslemleri : Form
    {
        private Islemler.KitapIslemleri oi;
        private List<Kitap> al;


        public KitapIslemleri()
        {
            if (al == null) al = new List<Kitap>();
            if (oi == null) oi = new Islemler.KitapIslemleri();
            InitializeComponent();

        }
        
        private void KitapIslemleri_Load(object sender, EventArgs e)
        {
            yukle();
        }

        private void yukle()
        {
            al = oi.tamaminiGetir();
                        
            var kitapListesi = al
            .Select(k => new {
                KitapId = k.KitapID,
                KitapAdi = k.KitapAdi,
                YayinEvi = k.YayinEvi,
                BarkodNo = k.BarkodNo,
                SayfaSayisi = k.SayfaSayisi,
                KitapAciklama = k.KitapAciklama,
                KitapTuruAdi = k.KitapTuru.KitapTuruAdi,
                YazarAdSoyad = k.Yazar.YazarAdSoyad,
                KayitTarihi = k.KayitTarihi,
                KitapTuruId = k.KitapTuruID,
                YazarId = k.YazarID,
            }).OrderBy(p=>p.KitapAdi).ToList();
            
            dataGridView1.DataSource = kitapListesi;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;


        }


        private void button2_Click(object sender, EventArgs e)
        {
            KitapTuruSayfasi kitapTuru = new KitapTuruSayfasi();
            kitapTuru.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YazarSayfası yazarSayfasi = new YazarSayfası();
            yazarSayfasi.ShowDialog();
        }

        //ekle
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == ""
                || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Boş Kayıt Eklenemez");
                return;
            }
          
            Kitap o = new Kitap();
            o.KitapAdi = textBox2.Text;
            o.YayinEvi = textBox1.Text;
            o.KitapAciklama = textBox3.Text;
            o.SayfaSayisi = Convert.ToInt32(textBox6.Text);
            o.BarkodNo = textBox5.Text;
            o.YazarID = Convert.ToInt32(label1.Text);
            o.KitapTuruID = Convert.ToInt32(label8.Text);
            o.KayitTarihi = DateTime.Now;
            al.Add(o);
            oi.Ekle(o);
            
            yukle();
            temizle();

        }
        void arayuzdenVeriYukle()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = al;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
        }
        private void temizle()
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

        }
       //Arama
        private void textBox8_TextChanged(object sender, EventArgs e)
      {
            if (textBox8.Text.Length == 0)
            {
                yukle();
            }
            else
            {
                List<Kitap> gl = oi.sorgula(o => o.KitapAdi.Contains(textBox8.Text) || o.YayinEvi.Contains(textBox8.Text) ||
                o.BarkodNo.ToLower().Contains(textBox8.Text.ToLower()) || o.KitapTuru.KitapTuruAdi.ToLower().Contains(textBox8.Text.ToLower()) || o.Yazar.YazarAdSoyad.ToLower().Contains(textBox8.Text.ToLower()));

               var kitapListesi = gl
            .Select(k => new
            {
                KitapAdi = k.KitapAdi,
                YayinEvi = k.YayinEvi,
                BarkodNo = k.BarkodNo,
                SayfaSayisi = k.SayfaSayisi,
                KitapAciklama = k.KitapAciklama,
                KitapTuruAdi = k.KitapTuru.KitapTuruAdi,
                YazarAdSoyad = k.Yazar.YazarAdSoyad,
                KayitTarihi = k.KayitTarihi,

            }).ToList();
                dataGridView1.DataSource = kitapListesi;
            }
        }


           //sil
        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir = dataGridView1.SelectedRows[0];
            if (secilenSatir != null)
            {
                DialogResult dialogResult = MessageBox.Show("Kitabı silmek istediğinizden emin misiniz?", "Kitap Silme İşlemi", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(secilenSatir.Cells[0].Value);
                    Kitap so = al.Where(o => o.KitapID == id).FirstOrDefault();
                    if (so != null)
                    {
                       
                        oi.Sil(so);
                        al.Remove(so);
                        yukle();
                        temizle();
                    }
                    else
                    {
                        MessageBox.Show("Kitap Bulunamadığından Silinemedi");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                 
                }
              
            }
            else
            {

                MessageBox.Show("Önce Silinecek Kaydı Seçiniz");

            }
        }

        // çift tıklamayla kayıtların textboxlara yazılması
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0 && i < dataGridView1.Rows.Count)
            {
                DataGridViewRow secilen = dataGridView1.Rows[i];


                object[] veri = secilen.Cells.Cast<DataGridViewCell>().Select(x => x.Value).ToArray();
                textBox7.Text = veri[6].ToString(); 
                textBox2.Text = veri[1].ToString(); 
                textBox1.Text = veri[2].ToString(); 
                textBox4.Text = veri[7].ToString(); 
                textBox3.Text = veri[5].ToString(); 
                textBox6.Text = veri[4].ToString();
                textBox5.Text = veri[3].ToString();
                //yazarId
                label1.Text = veri[10].ToString(); // kitap güncellerken yazar adınıda güncellemek için yazar idsine ulaştık.
                //kitapId
                label8.Text = veri[9].ToString(); //  kitap güncellerken kitap türü adınıda güncellemek için kitap tür idsine ulaştık
            }
        }

        // kitap güncelleme
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == ""
                || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Boş Kayıt Güncellenemez!");
                return;
            }
            DataGridViewRow secilenSatir = dataGridView1.SelectedRows[0];
            if (secilenSatir != null)
            {
                int id = Convert.ToInt32(secilenSatir.Cells[0].Value);
                Kitap go = oi.tekilGetir(id);
               
                if (go != null)
                {
                    go.KitapAdi = textBox2.Text;
                    go.YayinEvi = textBox1.Text;
                    go.KitapAciklama = textBox3.Text;
                    go.SayfaSayisi = Convert.ToInt32(textBox6.Text);
                    go.BarkodNo = textBox5.Text;
                    go.KitapTuruID = Convert.ToInt32(label8.Text);
                    go.YazarID = Convert.ToInt32(label1.Text);
                    go.KayitTarihi = DateTime.Now;
                    oi.Guncelle(go);
                    yukle();
                    temizle();
                }
                else
                {
                    MessageBox.Show("Kitap Bulunamadığından Güncellenemedi");
                }
            }
            else
            {
                MessageBox.Show("Veriler Hatalı Formatta OLduğundan Güncellenemedi");
            }

            temizle();
        }
    }
}
