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
    public partial class KullaniciEkleForm : Form
    {
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        public KullaniciEkleForm()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            

            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }
        private void KullaniciEkleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void kullaniciEkleBtn_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanicilar = new Kullanicilar();
            kullanicilar.kullanici_ad = kullaniciAdText.Text;
            kullanicilar.kullanici_soyad = kullaniciSoyadText.Text;
            kullanicilar.kullanici_tc = kullaniciTcText.Text;
            kullanicilar.kullanici_tel = kullaniciTelText.Text;
            kullanicilar.kullanici_mail = kullaniciMailText.Text;
            kullanicilar.kullanici_ceza = Convert.ToDouble(kullaniciCezaText.Text);
            if (kullaniciErkekRad.Checked == true)
            {
                kullanicilar.kullanici_cinsiyet = "E";
            }
            else if (kullaniciKadınRad.Checked == true)
            {
                kullanicilar.kullanici_cinsiyet = "K";
            }
            db.Kullanicilar.Add(kullanicilar);
            db.SaveChanges();
            Listele();

        }
    }
}
