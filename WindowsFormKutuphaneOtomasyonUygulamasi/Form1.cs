using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormKutuphaneOtomasyonUygulamasi
{
    public partial class Form1 : Form
    {
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void personelGirisBtn_Click(object sender, EventArgs e)
        {
            string gelenAd = adGiris.Text;
            string gelenSifre = sifreGiris.Text;

            var personel = db.Personeller.Where(x => x.personel_kullaniciAdi.Equals(gelenAd)&& x.personel_sifre.Equals(gelenSifre)).FirstOrDefault();

            if (personel == null)
            {
                MessageBox.Show("Yanlış");
            }
            else
            {
                MessageBox.Show("Doğru");
                IslemPaneli panel = new IslemPaneli();
                panel.Show();
                this.Hide();
            }
        }
    }
}
