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
    public partial class MüşteriSilme : Form
    {
        public MüşteriSilme()
        {
            InitializeComponent();
        }
        OtoGaleriOtomasyonuEntities1 db = new OtoGaleriOtomasyonuEntities1();
        private void btnMenüDön_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seçim_Ekranı frm17=new Seçim_Ekranı();
            frm17.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnMüşteriyiSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtMüşteriIdSil.Text);
            var query = db.TBLMÜSTERİLER.Find(id);
            db.TBLMÜSTERİLER.Remove(query);
            db.SaveChanges();
            MessageBox.Show("Kayıt Silindi","Kayıt Silme Ekranı",MessageBoxButtons.OK);



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
