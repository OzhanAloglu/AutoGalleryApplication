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
    public partial class PersonelListesi : Form
    {
        public PersonelListesi()
        {
            InitializeComponent();
        }

       
            OtoGaleriOtomasyonuEntities1 db = new OtoGaleriOtomasyonuEntities1();
        

        private void btnMenüDön_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seçim_Ekranı frm15 = new Seçim_Ekranı();
            frm15.ShowDialog();
        }

        public void personellist()
        {
            var query = from item in db.TBLPERSONELLER
                        select new { item.PersonelAd, item.PersonelSoyad, item.PersonelYas, item.PersonelTc, item.PersonelMail, item.PersonelTelefon, item.PersonelAdres, item.PersonelŞubeNo };
            dataGridView1.DataSource = query.ToList();

            
        }

        private void btnPersoneller_Click(object sender, EventArgs e)
        {
            
            personellist();

        }
    }
}
