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
    public partial class EmanetKitaplar : Form
    {
        public EmanetKitaplar()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            UyeEkle uye = new UyeEkle();
            uye.Show();
            this.Hide();
        }
    }
}
