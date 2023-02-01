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
    public partial class ŞubeEkle : Form
    {
        public ŞubeEkle()
        {
            InitializeComponent();
        }
        OtoGaleriOtomasyonuEntities1 db = new OtoGaleriOtomasyonuEntities1();

        private void btnMenüDön_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seçim_Ekranı frm30 = new Seçim_Ekranı();
            frm30.ShowDialog();
        }

        private void btnŞubeEkle_Click(object sender, EventArgs e)
        {
            try
            {

                TBLŞUBELER tblsube = new TBLŞUBELER();
                tblsube.ŞubeAdı = txtŞubeAdıEkle.Text;
                tblsube.ŞubePersoneller = Convert.ToInt32(txtŞubePersonelEkle.Text);
                tblsube.ŞubeAdresi = txtŞubeAdresEkle.Text;
                db.TBLŞUBELER.Add(tblsube);
                db.SaveChanges();
                MessageBox.Show("Yeni Şube Başarıyla Eklenmiştir.", "Şube Ekleme Ekranı", MessageBoxButtons.OK);
            }
            catch (Exception)
            {

                MessageBox.Show("Bilgileri Doğru giriniz.");
            }
        }

        private void btnŞubeListele_Click(object sender, EventArgs e)
        {
            var query = from item in db.TBLŞUBELER
                        select new { item.ŞubeNo, item.ŞubeAdı, item.ŞubePersoneller, item.ŞubeAdresi };
            dataGridView1.DataSource = query.ToList();
        }
    }
}
