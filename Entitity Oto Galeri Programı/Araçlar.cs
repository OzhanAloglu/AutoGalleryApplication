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
    public partial class Araçlar : Form
    {
        public Araçlar()
        {
            InitializeComponent();
        }
        OtoGaleriOtomasyonuEntities1 db=new OtoGaleriOtomasyonuEntities1();

        private void btnMenüDön_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seçim_Ekranı frm24 = new Seçim_Ekranı();
            frm24.ShowDialog();
        }

        private void btn_Araçgöster_Click(object sender, EventArgs e)
        {

            var query = from item in db.TBLARAÇLAR
                        select new { item.AraçNo, item.AraçFiyat, item.AraçMarka, item.AraçModel, item.AraçTip, item.AraçVites, item.AraçPaket, item.AraçRenk,item.AraçŞubeNo,item.AraçDurum, item.AraçFoto };
            dataGridView1.DataSource = query.ToList();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            //txtAraçNoGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            //txtAraçFiyatGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[1].Value.ToString();
            //txtAraçMarkaGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[2].Value.ToString();
            //txtAraçModelGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[3].Value.ToString();
            //txtAraçTipGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[4].Value.ToString();
            //txtAraçVitesGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[5].Value.ToString();
            //txtAraçPaketGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[6].Value.ToString();
            //txtAraçRenkGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[7].Value.ToString();
            //txtŞubeNoGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[9].Value.ToString();
            //txtAraçDurumGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[10].Value.ToString();


            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;

            txtAraçNoGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            txtAraçFiyatGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[1].Value.ToString();
            txtAraçMarkaGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[2].Value.ToString();
            txtAraçModelGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[3].Value.ToString();
            txtAraçTipGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[4].Value.ToString();
            txtAraçVitesGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[5].Value.ToString();
            txtAraçPaketGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[6].Value.ToString();
            txtAraçRenkGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[7].Value.ToString();
            txtŞubeNoGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[8].Value.ToString();
            txtAraçDurumGüncelle.Text = dataGridView1.Rows[seçilialan].Cells[9].Value.ToString();
            txtUrl2.Text = dataGridView1.Rows[seçilialan].Cells[10].Value.ToString();

            pictureBox2.ImageLocation = dataGridView1.Rows[seçilialan].Cells[10].Value.ToString();
        }

        private void Araçlar_Load(object sender, EventArgs e)
        {

        }
    }
}
