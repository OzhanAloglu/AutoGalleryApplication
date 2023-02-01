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
    public partial class MüşteriSeçimi : Form
    {
        public MüşteriSeçimi()
        {
            InitializeComponent();
        }
        OtoGaleriOtomasyonuEntities1 db=new OtoGaleriOtomasyonuEntities1();
       
        private void MüşteriSeçimi_Load(object sender, EventArgs e)
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
            Sözleşme sözleşme = new Sözleşme();
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            sözleşme.txt_MüşteriNo.Text = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            sözleşme.txt_MüşteriAd.Text = dataGridView1.Rows[seçilialan].Cells[1].Value.ToString();
            sözleşme.txtMüşteriSoyad.Text = dataGridView1.Rows[seçilialan].Cells[2].Value.ToString();
            sözleşme.txtMüşteriMail.Text= dataGridView1.Rows[seçilialan].Cells[3].Value.ToString();
            sözleşme.txtMüşteriTelefon.Text = dataGridView1.Rows[seçilialan].Cells[4].Value.ToString();
            sözleşme.txtMüşteriAdres.Text = dataGridView1.Rows[seçilialan].Cells[5].Value.ToString();
            sözleşme.Show();

            this.Hide();
           
        }
    }
}
