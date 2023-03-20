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
using WindowsFormKutuphaneOtomasyonUygulamasi.Kaynak;
using WindowsFormKutuphaneOtomasyonUygulamasi.Kayit;

namespace WindowsFormKutuphaneOtomasyonUygulamasi
{
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            //Kullanici kapalı
            ekleKullaniciBtn.Visible = false;
            guncelleKullaniciBtn.Visible = false;
            silKullaniciBtn.Visible = false;

            //Kaynaklar kapalı
            kaynaklarEkleBtn.Visible = false;
            kaynaklarSilBtn.Visible = false;
            kaynaklarGuncellBtn.Visible = false;
        }

        private void kullanicilar_Click(object sender, EventArgs e)
        {
            if (ekleKullaniciBtn.Visible == false)
            {
                ekleKullaniciBtn.Visible = true;
                guncelleKullaniciBtn.Visible = true;
                silKullaniciBtn.Visible = true;
            }
            else
            {
                ekleKullaniciBtn.Visible = false;
                guncelleKullaniciBtn.Visible = false;
                silKullaniciBtn.Visible = false;
            }

            KullaniciListeForm kullaniciListeForm = new KullaniciListeForm();
            kullaniciListeForm.MdiParent = this;
            kullaniciListeForm.Show();



        }

        private void ekleKullaniciBtn_Click(object sender, EventArgs e)
        {
            KullaniciEkleForm kullaniciEkleForm = new KullaniciEkleForm();
            kullaniciEkleForm.MdiParent = this;
            kullaniciEkleForm.Show();
        }

        private void silKullaniciBtn_Click(object sender, EventArgs e)
        {
            KullaniciSilForm kullaniciSilForm = new KullaniciSilForm();
            kullaniciSilForm.MdiParent = this;
            kullaniciSilForm.Show();
        }

        private void guncelleKullaniciBtn_Click(object sender, EventArgs e)
        {
            KullaniciGuncelleForm kullaniciGuncelleForm = new KullaniciGuncelleForm();
            kullaniciGuncelleForm.MdiParent = this;
            kullaniciGuncelleForm.Show();
        }

        private void kaynaklarBtn_Click(object sender, EventArgs e)
        {
            if (kaynaklarEkleBtn.Visible == false)
            {
                kaynaklarEkleBtn.Visible = true;
                kaynaklarSilBtn.Visible = true;
                kaynaklarGuncellBtn.Visible = true;
            }
            else
            {
                kaynaklarEkleBtn.Visible = false;
                kaynaklarSilBtn.Visible = false;
                kaynaklarGuncellBtn.Visible = false;
            }
            KaynakListForm kaynakListeForm = new KaynakListForm();
            kaynakListeForm.MdiParent = this;
            kaynakListeForm.Show();
        }

        private void kaynaklarEkleBtn_Click(object sender, EventArgs e)
        {
            KaynakEkleForm kaynakEkleForm = new KaynakEkleForm();
            kaynakEkleForm.MdiParent = this;
            kaynakEkleForm.Show();
        }

        private void kaynaklarSilBtn_Click(object sender, EventArgs e)
        {
            KaynakSilForm kaynakSilForm = new KaynakSilForm();
            kaynakSilForm.MdiParent = this;
            kaynakSilForm.Show();
        }

        private void kaynaklarGuncellBtn_Click(object sender, EventArgs e)
        {
            KaynakGuncelleForm kaynakGuncelleForm = new KaynakGuncelleForm();
            kaynakGuncelleForm.MdiParent = this;
            kaynakGuncelleForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OduncVerForm oduncVerForm = new OduncVerForm();
            oduncVerForm.MdiParent = this;
            oduncVerForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GeriAlForm geriAlForm = new GeriAlForm();
            geriAlForm.MdiParent = this;
            geriAlForm.Show();
        }
    }
}
