using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane.Formlar
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            KitapIslemleri kitapEkle = new KitapIslemleri();
            kitapEkle.Show();   
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            UyeEkle uyeEkle = new UyeEkle();
            uyeEkle.Show();
        }

        private void btnUyeListe_Click(object sender, EventArgs e)
        {
           
        }

        private void btnKitapTur_Click(object sender, EventArgs e)
        {
            KitapTuruSayfasi kitapTuru = new KitapTuruSayfasi();  
            kitapTuru.Show();   
        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEmanetKitap_Click(object sender, EventArgs e)
        {
            EmanetKitaplar emanetKitaplar = new EmanetKitaplar();
            emanetKitaplar.Show();  
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
           
        }
    }
}
