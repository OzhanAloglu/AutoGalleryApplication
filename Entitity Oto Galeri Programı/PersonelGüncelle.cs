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
    public partial class PersonelGüncelle : Form
    {
        public PersonelGüncelle()
        {
            InitializeComponent();
        }
        OtoGaleriOtomasyonuEntities1 db = new OtoGaleriOtomasyonuEntities1();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seçim_Ekranı frm14 = new Seçim_Ekranı();
            frm14.ShowDialog();
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtPersonelNo.Text);

                var a = db.TBLPERSONELLER.Find(id);
                a.PersonelAd = txtPersonelAdGüncelle.Text;
                a.PersonelSoyad = txtPersonelSoyadGüncelle.Text;
                a.PersonelYas = Convert.ToInt32(txtPersonelYasGüncelle.Text);
                a.PersonelTc = mskPersonelTcGüncelle.Text;
                a.PersonelMail = txtPersonelMailGüncelle.Text;
                a.PersonelTelefon = mskdPersonelTelGüncelle.Text;
                a.PersonelAdres = txtPersonelAdresGüncelle.Text;
                a.PersonelŞubeNo = Convert.ToInt32(txtPersonelŞubeGüncelle.Text);
                db.SaveChanges();
                MessageBox.Show("Güncelleme İşlemi Yapıldı.", "Personel Güncelleme Ekranı", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen listeden Müşteriyi bulunuz");

            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = from item in db.TBLPERSONELLER
                        select new { item.PersonelNo,item.PersonelAd, item.PersonelSoyad, item.PersonelYas, item.PersonelTc, item.PersonelMail, item.PersonelTelefon, item.PersonelAdres, item.PersonelŞubeNo };
            dataGridView1.DataSource = query.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            txtPersonelNo.Text = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            txtPersonelAdGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[1].Value.ToString();
            txtPersonelSoyadGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[2].Value.ToString();
            txtPersonelYasGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[3].Value.ToString();
            mskPersonelTcGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[4].Value.ToString();
            txtPersonelMailGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[5].Value.ToString();
            mskdPersonelTelGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[6].Value.ToString();
            txtPersonelAdresGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[7].Value.ToString();
            txtPersonelŞubeGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[8].Value.ToString();
            
        }
    }
}
