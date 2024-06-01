using Islemler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Varliklar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kutuphane.Formlar
{
    public partial class KitapTuruSayfasi : Form
    {
        private KitapTuruIslemleri oi;
        private List<KitapTuru> al;
        public KitapTuruSayfasi()
        {
            if (al == null) al = new List<KitapTuru>();
            if (oi == null) oi = new KitapTuruIslemleri();
            InitializeComponent();
           
        }
          
        private void KitapTuru_Load(object sender, EventArgs e)
        {
            yukle();
        }
        private void yukle()
        {
            al = oi.tamaminiGetir().OrderBy(p => p.KitapTuruID).ToList();
            dataGridView1.DataSource = al;
            dataGridView1.Columns[0].Visible = false;

        }
        private void temizle()
        {

            textBox2.Clear();

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Boş Kayıt Eklenemez");
                return;
            }
            KitapTuru o = new KitapTuru();
            o.KitapTuruAdi = textBox2.Text;
            al.Add(o);
            oi.Ekle(o);
            arayuzdenVeriYukle();
            temizle();

        }
        void arayuzdenVeriYukle()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = al;
            dataGridView1.Columns[0].Visible = false;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // burada silme işlemini try catch blokları arasına aldık çünkü ilgili kayıda ait veri sildiğinde hata fırlatması için
            try
            {
                DataGridViewRow secilenSatir = dataGridView1.SelectedRows[0];
                if (secilenSatir != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Kitap Türü silmek istediğinizden emin misiniz?", "Kitap Tür Silme İşlemi", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(secilenSatir.Cells[0].Value);
                        KitapTuru so = al.Where(o => o.KitapTuruID == id).FirstOrDefault();
                        if (so != null)
                        {

                            oi.Sil(so);
                            al.Remove(so);
                            arayuzdenVeriYukle();
                            temizle();
                        }
                        else
                        {
                            MessageBox.Show("Kitap Türü Bulunamadığından Silinemedi");
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
            catch (DbUpdateException ex)
            {
                // hatayı burada yakaladık.
               MessageBox.Show($"Silmek istenilen kitap türüne ait kitaplarda kayıt olduğu için silinemez!");
                
               
            }
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Boş Kayıt Güncellenemez");
                return;
            }
            DataGridViewRow secilenSatir = dataGridView1.SelectedRows[0];
            if (secilenSatir != null && textBox2.Text != "")
            {
                int id = Convert.ToInt32(secilenSatir.Cells[0].Value);
                KitapTuru go = al.Where(o => o.KitapTuruID == id).FirstOrDefault();
                if (go != null)
                {
                    go.KitapTuruAdi = textBox2.Text;
                    oi.Guncelle(go);
                    arayuzdenVeriYukle();
                    temizle();
                }
                else
                {
                    MessageBox.Show("Kitap Türü Bulunamadığından Güncellenemedi");
                }
            }
            else
            {
                MessageBox.Show("Veriler Hatalı Formatta OLduğundan Güncellenemedi");
            }

            temizle();
        }


      
        private void button4_Click(object sender, EventArgs e)
        {
            KitapIslemleri kitapIslemleri = (KitapIslemleri)Application.OpenForms["KitapIslemleri"];
            kitapIslemleri.label8.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            kitapIslemleri.textBox7.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0 && i < dataGridView1.Rows.Count)
            {
                DataGridViewRow secilen = dataGridView1.Rows[i];

                object[] veri = secilen.Cells.Cast<DataGridViewCell>().Select(x => x.Value).ToArray();
                textBox2.Text = veri[1].ToString();

            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                yukle();
            }
            else
            {
                List<KitapTuru> gl = oi.sorgula(o => o.KitapTuruAdi.Contains(textBox1.Text) || o.KitapTuruAdi.ToLower().Contains(textBox1.Text.ToLower())
                || o.KitapTuruAdi.ToLower().Contains(textBox1.Text.ToLower()));
                dataGridView1.DataSource = gl;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
