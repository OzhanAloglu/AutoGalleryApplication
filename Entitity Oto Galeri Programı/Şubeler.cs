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
    public partial class Şubeler : Form
    {
        public Şubeler()
        {
            InitializeComponent();
        }
        OtoGaleriOtomasyonuEntities1 db=new OtoGaleriOtomasyonuEntities1();

        public void seçimekranı()
        {
            Seçim_Ekranı frm = new Seçim_Ekranı();
            frm.ShowDialog();
            this.Hide();
        }


        private void btnMenüDön_Click(object sender, EventArgs e)
        {
            seçimekranı();
        }

        private void btnSubeler_Click(object sender, EventArgs e)
        {
            var query = from item in db.TBLŞUBELER
                        select new { item.ŞubeNo, item.ŞubeAdı, item.ŞubePersoneller, item.ŞubeAdresi};
            dataGridView1.DataSource = query.ToList();
        }
    }
}
