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
    public partial class ŞubeSilme : Form
    {
        public ŞubeSilme()
        {
            InitializeComponent();
        }
        OtoGaleriOtomasyonuEntities1 db=new OtoGaleriOtomasyonuEntities1();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seçim_Ekranı frm36 = new Seçim_Ekranı();
            frm36.ShowDialog();
        }

        private void btnŞubeListele_Click(object sender, EventArgs e)
        {
            var query = from item in db.TBLŞUBELER
                        select new { item.ŞubeNo, item.ŞubeAdı, item.ŞubePersoneller, item.ŞubeAdresi };
            dataGridView1.DataSource = query.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);

            var sil=db.TBLŞUBELER.Find(id);
            db.TBLŞUBELER.Remove(sil);
            db.SaveChanges();
            MessageBox.Show("Şube Silindi.","Şube Silme Ekranı",MessageBoxButtons.OK);
        }
    }
}
