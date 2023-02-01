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
    public partial class AraçEkle : Form
    {
        public AraçEkle()
        {
            InitializeComponent();
        }
        OtoGaleriOtomasyonuEntities1 db = new OtoGaleriOtomasyonuEntities1();

        private void btnAraçEkle_Click(object sender, EventArgs e)
        {
            TBLARAÇLAR ekle = new TBLARAÇLAR();
            ekle.AraçMarka = txtAraçMarka.Text;
            ekle.AraçModel =Convert.ToInt32( txtAraçModel.Text);
            ekle.AraçTip = txtAraçTip.Text;
            ekle.AraçPaket = txtAraçPaket.Text;
            ekle.AraçRenk = txtAraçRenk.Text;
            ekle.AraçŞubeNo = Convert.ToInt32(txtAraçŞuBEnO.Text);
            ekle.AraçDurum = txtAraçDurum.Text;
            ekle.AraçFiyat = Convert.ToInt32(txtAraçFiyat.Text);

            db.TBLARAÇLAR.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Yeni Araç Başarıyla Eklenmiştir.", "Araç Ekleme Ekranı", MessageBoxButtons.OK);


        }

        private void btnAraçGöster_Click(object sender, EventArgs e)
        {
            var query = from item in db.TBLARAÇLAR
                        select new {item.AraçMarka, item.AraçModel, item.AraçTip, item.AraçPaket, item.AraçRenk, item.AraçŞubeNo, item.AraçDurum, item.AraçFiyat};
            dataGridView1.DataSource = query.ToList();
        }

        private void txtMenüDön_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seçim_Ekranı frm24 = new Seçim_Ekranı();
            frm24.ShowDialog();
        }
    }
}
