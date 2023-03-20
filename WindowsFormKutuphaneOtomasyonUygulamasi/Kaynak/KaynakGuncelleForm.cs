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
    public partial class KaynakGuncelleForm : Form
    {
        public KaynakGuncelleForm()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        public void Listele()
        {
            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();
        }



        private void KaynakGuncelleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            kaynakAdTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            kaynakYazarTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            kaynakYayinciTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            kaynakSayfaSayisi.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value);
            kaynakTarih.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5 ].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kaynak = db.Kaynaklar.Where(x => x.kaynak_id == secilenId).FirstOrDefault();
            kaynak.kaynak_ad = kaynakAdTxt.Text;
            kaynak.kaynak_yazarad = kaynakYazarTxt.Text;
            kaynak.kaynak_yayinci = kaynakYayinciTxt.Text;
            kaynak.kaynak_sayfasayisi = Convert.ToInt16(kaynakSayfaSayisi.Value);
            kaynak.kaynak_basimTarihi = kaynakTarih.Value;
            db.SaveChanges();
            Listele();
        }
    }
}
