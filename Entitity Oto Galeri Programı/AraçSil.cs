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
    public partial class AraçSil : Form
    {
        public AraçSil()
        {
            InitializeComponent();
        }
        OtoGaleriOtomasyonuEntities1 db = new OtoGaleriOtomasyonuEntities1();
        private void btnMenüDön_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seçim_Ekranı frm21 = new Seçim_Ekranı();
            frm21.ShowDialog();
        }

        private void btnAracıSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            var query = db.TBLARAÇLAR.Find(id);
            db.TBLARAÇLAR.Remove(query);
            db.SaveChanges();
            MessageBox.Show("Araç silindi.", "Araç Silme Ekranı", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = from item in db.TBLPERSONELLER
                        select new { item.PersonelNo, item.PersonelAd, item.PersonelSoyad, item.PersonelYas, item.PersonelTc, item.PersonelMail, item.PersonelTelefon, item.PersonelAdres, item.PersonelŞubeNo };
            dataGridView1.DataSource = query.ToList();
        }
    }
}
