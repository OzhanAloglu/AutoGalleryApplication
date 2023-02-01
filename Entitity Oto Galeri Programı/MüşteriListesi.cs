using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entitity_Oto_Galeri_Programı
{
    public partial class MüşteriListesi : Form
    {
        public MüşteriListesi()
        {
            InitializeComponent();
        }

        OtoGaleriOtomasyonuEntities1 db = new OtoGaleriOtomasyonuEntities1();

        private void btnMenüDön_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seçim_Ekranı frm16 = new Seçim_Ekranı();
            frm16.ShowDialog();
        }

        private void btnMüşteriListele_Click(object sender, EventArgs e)
        {

            var query = from item in db.TBLMÜSTERİLER
                        select new
                        {
                            item.MüşteriNo,
                            item.MüşteriAd,
                            item.MüşteriSoyad,
                            item.MüşteriMail,
                            item.MüşteriTelefon,
                            item.MüşteriAdres
                        };
            dataGridView1.DataSource = query.ToList();

        }
    }
}
