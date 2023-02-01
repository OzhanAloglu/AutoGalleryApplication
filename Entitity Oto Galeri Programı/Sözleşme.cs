using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Entitity_Oto_Galeri_Programı
{
    public partial class Sözleşme : Form
    {
        public Sözleşme()
        {
            InitializeComponent();
        }
        public string TurkceKarakter(string betim)
        {
            Text = Text.Replace("İ", "\u0130");
            Text = Text.Replace("ı", "\u0131");
            Text = Text.Replace("Ş", "\u015e");
            Text = Text.Replace("Ğ", "\u011e");
            Text = Text.Replace("Ö", "\u00d6");
            Text = Text.Replace("Ç", "\u00c7");
            Text = Text.Replace("Ü", "\u00dc");
            return Text;

        }
        OtoGaleriOtomasyonuEntities1 db = new OtoGaleriOtomasyonuEntities1();

        private void Sözleşme_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.sözlesme2();
            label24.Visible = false;
            txt_kiralıkgünsayısı.Visible = false;



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int seçilialan = dataGridView1.SelectedCells[0].RowIndex;

                txt_Marka.Text = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
                txt_Model.Text = dataGridView1.Rows[seçilialan].Cells[1].Value.ToString();
                txt_Paket.Text = dataGridView1.Rows[seçilialan].Cells[2].Value.ToString();
                txt_vites.Text = dataGridView1.Rows[seçilialan].Cells[3].Value.ToString();
                txt_renk.Text = dataGridView1.Rows[seçilialan].Cells[4].Value.ToString();
                txt_durum.Text = dataGridView1.Rows[seçilialan].Cells[5].Value.ToString();

                txtAraçFiyatı.Text = dataGridView1.Rows[seçilialan].Cells[6].Value.ToString();
                txt_personelno.Text = dataGridView1.Rows[seçilialan].Cells[7].Value.ToString();

                txt_personelad.Text = dataGridView1.Rows[seçilialan].Cells[8].Value.ToString();
                txt_soyad.Text = dataGridView1.Rows[seçilialan].Cells[9].Value.ToString();
                txt_tc.Text = dataGridView1.Rows[seçilialan].Cells[10].Value.ToString();
                txt_mail.Text = dataGridView1.Rows[seçilialan].Cells[11].Value.ToString();
                txt_subeno.Text = dataGridView1.Rows[seçilialan].Cells[12].Value.ToString();
                txt_şubeadı.Text = dataGridView1.Rows[seçilialan].Cells[13].Value.ToString();

                txt_toplamtutar.Text = txtAraçFiyatı.Text;
            }
            catch (Exception)
            {
                txt_Paket.Text = "";
                txt_Model.Text = "";
                txt_personelad.Text = "";
                txt_renk.Text = "";
                txt_vites.Text = "";
                txt_şubeadı.Text = "";
                txt_subeno.Text = "";
                txt_personelno.Text = "";
                txtAraçFiyatı.Text = "";
                txt_mail.Text = "";
                txt_tc.Text = "";
                txt_Marka.Text = "";
                txt_durum.Text = "";
                txt_soyad.Text = "";

                MessageBox.Show("Lütfen Yapmak İstediğiniz işlemi seçin.","İşlem Seçin",MessageBoxButtons.OK);
            }


        }

        private void btn_sözlesme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Araç Markası:"+txt_Marka.Text + "\n" +"Araç Modeli:"+ txt_Model.Text + "\n" +"Araç Paketi:"+ txt_Paket.Text + "\n" + "Araç Vitesi:"+txt_vites.Text + "\n" +"Araç Rengi:"+ txt_renk.Text+"\n"+"Araç Durum:"+txt_durum.Text+"\n"+"Araç Fiyatı:"+txtAraçFiyatı.Text+"\n"+
               "Personel Adı:"+ txt_personelad.Text+"\n"+"Personel Soyadı:"+txt_soyad.Text+"\n"+"Personel TC:"+txt_tc.Text+"\n"+"Personel Mail:"+txt_mail.Text+"\n"+"Personel No:"+txt_personelno.Text+"\n"+"Müşteri No:"+txt_MüşteriNo.Text+"\n"+"Müşteri Adı:"+txt_MüşteriAd.Text+"\n"+"Müşteri Soyadı:"+txtMüşteriSoyad.Text+"\n"+
               "Müşteri Mail:"+ txtMüşteriMail.Text+"\n"+"Müşteri Telefon:"+txtMüşteriTelefon.Text+"\n"+"Müşteri Adres:"+txtMüşteriAdres.Text,"Sözleşme Ekranı",MessageBoxButtons.YesNo);
           
        }

        private void btnMüşteriSeç_Click(object sender, EventArgs e)
        {
            
            MüşteriSeçimi müşteriSeçimi = new MüşteriSeçimi();
            müşteriSeçimi.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)

        {
            dataGridView1.DataSource = db.kiralıkaraclartablosu();
            label24.Visible = true;
            txt_kiralıkgünsayısı.Visible = true;
            txt_toplamtutar.Text = "";
            btn_FiyatHesapla.Visible = true;

            //int seçilialan = dataGridView1.SelectedCells[0].RowIndex;

            //txt_Marka.Text = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            //txt_Model.Text = dataGridView1.Rows[seçilialan].Cells[1].Value.ToString();
            //txt_Paket.Text = dataGridView1.Rows[seçilialan].Cells[2].Value.ToString();
            //txt_vites.Text = dataGridView1.Rows[seçilialan].Cells[3].Value.ToString();
            //txt_renk.Text = dataGridView1.Rows[seçilialan].Cells[4].Value.ToString();
            //txt_durum.Text = dataGridView1.Rows[seçilialan].Cells[5].Value.ToString();
            //txt_personelno.Text = dataGridView1.Rows[seçilialan].Cells[6].Value.ToString();
            //txt_personelad.Text = dataGridView1.Rows[seçilialan].Cells[7].Value.ToString();
            //txt_soyad.Text = dataGridView1.Rows[seçilialan].Cells[8].Value.ToString();
            //txt_tc.Text = dataGridView1.Rows[seçilialan].Cells[9].Value.ToString();
            //txt_mail.Text = dataGridView1.Rows[seçilialan].Cells[10].Value.ToString();
            //txt_subeno.Text = dataGridView1.Rows[seçilialan].Cells[11].Value.ToString();
            //txt_şubeadı.Text = dataGridView1.Rows[seçilialan].Cells[12].Value.ToString();

        }

        private void btn_FiyatHesapla_Click(object sender, EventArgs e)
        {
            
            int sayi1 = Convert.ToInt32(txtAraçFiyatı.Text);
            int sayi2 = Convert.ToInt32(txt_kiralıkgünsayısı.Text);
            txt_toplamtutar.Text = (sayi1 * sayi2).ToString();
        }

        private void btn_satınalma_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.satılıkaracprocedure();
            txt_toplamtutar.Text = txtAraçFiyatı.Text;
            label24.Visible = false;
            txt_kiralıkgünsayısı.Visible = false;
            btn_FiyatHesapla.Visible = false;
        }

        private void btn_menüdön_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seçim_Ekranı frm = new Seçim_Ekranı();
            frm.Show();
        }
    }
}
