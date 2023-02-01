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
    public partial class YeniMüşteriEkleme : Form
    {
        public YeniMüşteriEkleme()
        {
            InitializeComponent();
        }
        OtoGaleriOtomasyonuEntities1 db = new OtoGaleriOtomasyonuEntities1();
        private void btnMenüyeDön_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seçim_Ekranı frm12 = new Seçim_Ekranı();
            frm12.ShowDialog();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            TBLMÜSTERİLER tblmüsteri = new TBLMÜSTERİLER();
            tblmüsteri.MüşteriAd = txtMüşteriAdEkle.Text;
            tblmüsteri.MüşteriSoyad = txtMüşteriSoyadEkle.Text;
            tblmüsteri.MüşteriMail = txtMüşteriMailEkle.Text;
            tblmüsteri.MüşteriTelefon = mskdMüşteriTelEkle.Text;
            tblmüsteri.MüşteriAdres = txtMüşteriAdresEkle.Text;

            db.TBLMÜSTERİLER.Add(tblmüsteri);
            db.SaveChanges();
            MessageBox.Show("Yeni Müşteri Kayıt Edildi.", "Kayıt Ekranı", MessageBoxButtons.OK);
            


        }

        private void btnGöster_Click(object sender, EventArgs e)
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
