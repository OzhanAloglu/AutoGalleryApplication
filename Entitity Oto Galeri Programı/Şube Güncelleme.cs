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
    public partial class Şube_Güncelleme : Form
    {
        public Şube_Güncelleme()
        {
            InitializeComponent();
        }
        OtoGaleriOtomasyonuEntities1 db = new OtoGaleriOtomasyonuEntities1();
        private void btnMenüDön_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seçim_Ekranı frm31 = new Seçim_Ekranı();
            frm31.ShowDialog();
        }

        private void txtŞubeListele_Click(object sender, EventArgs e)
        {
            var query = from item in db.TBLŞUBELER
                        select new { item.ŞubeNo, item.ŞubeAdı, item.ŞubePersoneller, item.ŞubeAdresi };
            dataGridView1.DataSource = query.ToList();
        }

        private void btnŞubeGüncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtŞubeNoGüncelle.Text);

            var a = db.TBLŞUBELER.Find(id);
            a.ŞubeNo = Convert.ToInt32(txtŞubeNoGüncelle.Text);
            a.ŞubeAdı = txtSubeAdıGüncellemee.Text;
            a.ŞubePersoneller= Convert.ToInt32(txtŞubePersonelSayısıGüncelle.Text);
            a.ŞubeAdresi = txtŞubeAdresiGüncelle.Text;
            
            db.SaveChanges();

            MessageBox.Show("Şube Güncelleme İşlemi Yapıldı.", "Şube Güncelleme Ekranı", MessageBoxButtons.OK);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            txtŞubeNoGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            txtSubeAdıGüncellemee.Text = dataGridView1.Rows[seçilialan].Cells[1].Value.ToString();
            txtŞubePersonelSayısıGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[2].Value.ToString();
            txtŞubeAdresiGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[3].Value.ToString();
        }
    }
}
