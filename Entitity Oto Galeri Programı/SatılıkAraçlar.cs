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
    public partial class SatılıkAraçlar : Form
    {
        public SatılıkAraçlar()
        {
            InitializeComponent();
        }
        OtoGaleriOtomasyonuEntities1 db = new OtoGaleriOtomasyonuEntities1();

        private void btn_MenüDön_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seçim_Ekranı frm25 = new Seçim_Ekranı();
            frm25.ShowDialog();
        }

        private void btnSatılıkAraçGöster_Click(object sender, EventArgs e)
        {
            List<TBLARAÇLAR> listele=db.TBLARAÇLAR.Where(x=>x.AraçDurum=="Satılık").ToList();
            dataGridView1.DataSource = listele;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[seçilialan].Cells[10].Value.ToString();

            pictureBox1.ImageLocation = dataGridView1.Rows[seçilialan].Cells[10].Value.ToString();
        }
    }
}
