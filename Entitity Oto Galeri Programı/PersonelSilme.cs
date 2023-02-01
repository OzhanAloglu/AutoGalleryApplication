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
    public partial class PersonelSilme : Form
    {
        public PersonelSilme()
        {
            InitializeComponent();
        }
        OtoGaleriOtomasyonuEntities1 db = new OtoGaleriOtomasyonuEntities1();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seçim_Ekranı frm18 = new Seçim_Ekranı();
            frm18.ShowDialog();
        }

        private void btn_PersonelSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_SilinecekPersonelId.Text);

            var query = db.TBLPERSONELLER.Find(id);

            db.TBLPERSONELLER.Remove(query);
            db.SaveChanges();
            MessageBox.Show("Silme işlemi başarıyla gerçekleşti.","Personel Silme Ekranı",MessageBoxButtons.OK);

        }

        private void btn_personelgöster_Click(object sender, EventArgs e)
        {
            var query = from item in db.TBLPERSONELLER
                        select new { item.PersonelNo,item.PersonelAd, item.PersonelSoyad, item.PersonelYas, item.PersonelTc, item.PersonelMail, item.PersonelTelefon, item.PersonelAdres, item.PersonelŞubeNo };
            dataGridView1.DataSource = query.ToList();

        }
    }
}
