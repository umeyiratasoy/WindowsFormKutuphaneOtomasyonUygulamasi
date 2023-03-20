using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormKutuphaneOtomasyonUygulamasi.Kaynak
{
    public partial class KaynakEkleForm : Form
    {

        public KaynakEkleForm()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();
        }

        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            Kaynaklar kaynaklar = new Kaynaklar();
            kaynaklar.kaynak_ad = kaynakAdTxt.Text;
            kaynaklar.kaynak_yazarad = kaynakYazarTxt.Text;
            kaynaklar.kaynak_yayinci = kaynakYayinciTxt.Text;
            kaynaklar.kaynak_sayfasayisi = Convert.ToInt16(kaynakSayfaSayisi.Value);
            kaynaklar.kaynak_basimTarihi = kaynakTarih.Value;
            db.Kaynaklar.Add(kaynaklar);
            db.SaveChanges();
            Listele();
        }
    }
}
