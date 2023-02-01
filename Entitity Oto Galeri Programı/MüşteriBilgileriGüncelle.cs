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
    public partial class MüşteriBilgileriGüncelle : Form
    {
        public MüşteriBilgileriGüncelle()
        {
            InitializeComponent();
        }

        OtoGaleriOtomasyonuEntities1 db=new OtoGaleriOtomasyonuEntities1();

        private void btnMenüyeDön_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seçim_Ekranı frm13 = new Seçim_Ekranı();
            frm13.ShowDialog();
        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(txtMüşteriId.Text);

            var x = db.TBLMÜSTERİLER.Find(id);
            x.MüşteriAd = txtMüşteriAdGüncelle.Text;
            x.MüşteriSoyad = txtMüşteriSoyadGüncelle.Text;
            x.MüşteriMail = txtMüşteriMailGüncelle.Text;
            x.MüşteriTelefon = mskdMüşteriTelGüncelle.Text;
            x.MüşteriAdres = txtMüşteriAdresGüncelle.Text;
            db.SaveChanges();

            MessageBox.Show("Güncelleme İşlemi Yapıldı.", "Güncelleme Ekranı", MessageBoxButtons.OK);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            txtMüşteriId.Text = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            txtMüşteriAdGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[1].Value.ToString();
            txtMüşteriSoyadGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[2].Value.ToString();
            txtMüşteriMailGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[3].Value.ToString();
            mskdMüşteriTelGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[4].Value.ToString();
            txtMüşteriAdresGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[5].Value.ToString();
           
        }
    }
}
