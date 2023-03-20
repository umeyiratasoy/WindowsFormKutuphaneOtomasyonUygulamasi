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
    public partial class KaynakListForm : Form
    {
        public KaynakListForm()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();
        }

        private void KaynakListForm_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
