using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormKutuphaneOtomasyonUygulamasi.Kayit
{
    public partial class OduncVerForm : Form
    {
        public OduncVerForm()
        {
            InitializeComponent();
        }


        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

        private void OduncVerForm_Load(object sender, EventArgs e)
        {

            var kayitlar = db.Kayitlar.ToList();
            dataGridView1.DataSource = kayitlar.ToList();

            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView2.DataSource = kaynaklar.ToList();

            //Gizle
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;


            //Colon adı değiştirme
            dataGridView1.Columns[3].HeaderText = "Kaynak Ad";
            dataGridView1.Columns[2].HeaderText = "Kullanıcı";
            dataGridView1.Columns[1].HeaderText = "Personel";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arananTc = tcBulTxt.Text;
            var kullaniciVarMi = db.Kullanicilar.Where(x => x.kullanici_tc == arananTc).FirstOrDefault();
            if (kullaniciVarMi != null)
            {

                label2.Text = kullaniciVarMi.kullanici_ad + " " + kullaniciVarMi.kullanici_soyad;
            }
            else
            {
                label2.Text = "Böyle bir kullanıcı yok.";
            }
        }

        private void kaynakBulTxt_TextChanged(object sender, EventArgs e)
        {
            string gelenAd = kaynakBulTxt.Text;
            var bulunanKaynaklar = db.Kaynaklar.Where(x => x.kaynak_ad.Contains(gelenAd)).ToList();
            dataGridView2.DataSource = bulunanKaynaklar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Kişiyi aldık
            string secilenKisiTC = tcBulTxt.Text;
            var secilenKisi = db.Kullanicilar.Where(x => x.kullanici_tc.Equals(secilenKisiTC)).FirstOrDefault();

            //Kitabı aldık
            int secilenKitapId = Convert.ToInt16(dataGridView2.CurrentRow.Cells[0].Value);
            var secilenKitap = db.Kaynaklar.Where(x => x.kaynak_id == secilenKitapId).FirstOrDefault();

            Kayitlar yeniKayit = new Kayitlar();
            yeniKayit.kaynak_id = secilenKitap.kaynak_id;
            yeniKayit.kullanici_id = secilenKisi.kullanici_id;
            yeniKayit.alis_tarih = DateTime.Today;
            yeniKayit.son_tarih = DateTime.Today.AddDays(15);
            yeniKayit.durum = false;
            db.Kayitlar.Add(yeniKayit);
            db.SaveChanges();
            var kayitlar = db.Kayitlar.ToList();
            dataGridView1.DataSource = kayitlar.ToList();

        }
    }
}
