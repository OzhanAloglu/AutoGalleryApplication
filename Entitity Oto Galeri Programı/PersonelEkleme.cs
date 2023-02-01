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
    public partial class PersonelEkleme : Form
    {
        public PersonelEkleme()
        {
            InitializeComponent();
        }
        OtoGaleriOtomasyonuEntities1 db=new OtoGaleriOtomasyonuEntities1();

        private void btnMenüDön_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seçim_Ekranı frm26 = new Seçim_Ekranı();
            frm26.ShowDialog();
        }

        private void btn_PersonelEkle_Click(object sender, EventArgs e)
        {
            TBLPERSONELLER ekle=new TBLPERSONELLER();
            ekle.PersonelAd=txtEklePersonelAd.Text;
            ekle.PersonelSoyad=txtEklePersonelSoyad.Text;
            ekle.PersonelYas =Convert.ToInt32(txt_EklePersonelYas.Text);
            ekle.PersonelTc=mskdEklePersonelTc.Text;
            ekle.PersonelMail=txtEklePersonelMail.Text;
            ekle.PersonelTelefon = mskdEklePersonelTel.Text;
            ekle.PersonelAdres = txtEklePersonelAdres.Text;
            ekle.PersonelŞubeNo = Convert.ToInt32(txtEklePersonelŞube.Text);

            db.TBLPERSONELLER.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Yeni Personel Başarıyla Eklenmiştir.", "Personel Ekleme Ekranı", MessageBoxButtons.OK);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = from item in db.TBLPERSONELLER
                        select new { item.PersonelAd, item.PersonelSoyad, item.PersonelYas, item.PersonelTc, item.PersonelMail, item.PersonelTelefon, item.PersonelAdres, item.PersonelŞubeNo };
            dataGridView1.DataSource = query.ToList();

            dataGridView1.Columns[0].Visible = false;
        }
    }
}
