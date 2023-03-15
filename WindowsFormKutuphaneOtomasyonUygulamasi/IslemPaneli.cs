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
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            ekleKullaniciBtn.Visible = false;
            guncelleKullaniciBtn.Visible = false;
            silKullaniciBtn.Visible = false;
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
    }
}
