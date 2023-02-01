using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Entitity_Oto_Galeri_Programı
{
    public partial class AraçGüncelle : Form
    {
        public AraçGüncelle()
        {
            InitializeComponent();
        }
        OtoGaleriOtomasyonuEntities1 db=new OtoGaleriOtomasyonuEntities1();
        
        SqlConnection baglanti = new SqlConnection(@"Data Source = ALOGLU\SQLEXPRESS; Initial Catalog = OtoGaleriOtomasyonu; Integrated Security = True");
        
        private void btnMenüDön_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seçim_Ekranı frm27 = new Seçim_Ekranı();
            frm27.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = from item in db.TBLARAÇLAR
                        select new { item.AraçNo, item.AraçFiyat, item.AraçMarka, item.AraçModel, item.AraçTip, item.AraçVites, item.AraçPaket, item.AraçRenk,item.AraçŞubeNo, item.AraçDurum, item.AraçFoto };
            dataGridView1.DataSource = query.ToList();
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
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
                txtUrl.Text = dataGridView1.Rows[seçilialan].Cells[10].Value.ToString();

                pictureBox1.ImageLocation = dataGridView1.Rows[seçilialan].Cells[10].Value.ToString();
                
            }
            catch (Exception)
            {

                MessageBox.Show("Araç Güncellemesi yapmak için değişiklik yapınız.");
            }

        }

        private void btnAraçGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtAraçNoGüncelle.Text);

                var a = db.TBLARAÇLAR.Find(id);
                a.AraçNo = Convert.ToInt32(txtAraçNoGüncelle.Text);
                a.AraçFiyat = Convert.ToInt32(txtAraçFiyatGüncelle.Text);
                a.AraçMarka = txtAraçMarkaGüncelle.Text;
                a.AraçModel = Convert.ToInt32(txtAraçModelGüncelle.Text);
                a.AraçTip = txtAraçTipGüncelle.Text;
                a.AraçVites = txtAraçPaketGüncelle.Text;
                a.AraçPaket = txtAraçPaketGüncelle.Text;
                a.AraçRenk = txtAraçRenkGüncelle.Text;
                a.AraçDurum = txtAraçDurumGüncelle.Text;
                db.SaveChanges();

                MessageBox.Show("Güncelleme İşlemi Yapıldı.", "Araç Güncelleme Ekranı", MessageBoxButtons.OK);
            }
            catch (Exception)
            {

                MessageBox.Show("Listeden Araç Seçiniz, Değerler NULL olamaz.");
            }



           
        }

        private void btnResimSeç_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txtUrl.Text = openFileDialog1.FileName;


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLARAÇLAR (AraçFoto)values(@p1)",baglanti);
            komut.Parameters.AddWithValue("@p1",txtUrl.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt eklendi.");
        }
    }
}
