using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormKutuphaneOtomasyonUygulamasi.Kullanici;

namespace WindowsFormKutuphaneOtomasyonUygulamasi.Kullanici
{
    public partial class KullaniciGuncelleForm : Form
    {
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        public KullaniciGuncelleForm()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }

        private void KullaniciGuncelleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kullaniciAdText.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            kullaniciSoyadText.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            kullaniciTcText.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            kullaniciMailText.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            kullaniciTelText.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            kullaniciCezaText.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[7].Value.ToString().Equals("E"))
            {
                kullaniciErkekRad.Checked = true;
            }
            else
            {
                kullaniciKadınRad.Checked = true;
            }
        }

        private void kullaniciEkleBtn_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanici = db.Kullanicilar.Where(x => x.kullanici_id == secilenId).FirstOrDefault();
            kullanici.kullanici_ad = kullaniciAdText.Text;
            kullanici.kullanici_soyad = kullaniciSoyadText.Text;
            kullanici.kullanici_tc = kullaniciTcText.Text;
            kullanici.kullanici_tel = kullaniciTelText.Text;
            kullanici.kullanici_mail = kullaniciMailText.Text;
            kullanici.kullanici_ceza = Convert.ToDouble(kullaniciCezaText.Text);
            if (kullaniciErkekRad.Checked == true)
            {
                kullanici.kullanici_cinsiyet = "E";
            }
            else if (kullaniciKadınRad.Checked == true)
            {
                kullanici.kullanici_cinsiyet = "K";
            }
            db.SaveChanges();
            Listele();
        }
    }
}
