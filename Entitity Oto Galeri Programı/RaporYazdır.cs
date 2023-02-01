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

    public partial class RaporYazdır : Form
    {
        public RaporYazdır()
        {
            InitializeComponent();
        }
        OtoGaleriOtomasyonuEntities1 db = new OtoGaleriOtomasyonuEntities1();

        private void btn_RaporYazdır_Click(object sender, EventArgs e)
        {

            if (radioButton8.Checked == true)
            {
                List<TBLPERSONELLER> liste = db.TBLPERSONELLER.OrderBy(x => x.PersonelAd).ToList();
                dataGridView1.DataSource = liste;
            }

           

            if (radioButton1.Checked == true)
            {
                List<TBLMÜSTERİLER> liste = db.TBLMÜSTERİLER.Where(x => x.MüşteriAd.StartsWith("A")).ToList();
                dataGridView1.DataSource = liste;
                dataGridView1.Columns[5].Visible = false;

            }
            if (radioButton3.Checked == true)
            {
                List<TBLMÜSTERİLER> liste = db.TBLMÜSTERİLER.Where(x => x.MüşteriAdres == "Tuzla").ToList();
                dataGridView1.DataSource = liste;
            }

            if (radioButton4.Checked == true)
            {
                List<TBLMÜSTERİLER> liste = db.TBLMÜSTERİLER.Where(x => x.MüşteriNo < 10 && x.MüşteriNo > 5).ToList();
                dataGridView1.DataSource = liste;
            }

            if (radioButton5.Checked==true)
            {
                List<TBLPERSONELLER> liste = db.TBLPERSONELLER.Where(x => x.PersonelNo > 4).ToList();
                dataGridView1.DataSource = liste;
            }
            if (radioButton6.Checked==true)
            {
                List<TBLPERSONELLER> liste = db.TBLPERSONELLER.Where(x => x.PersonelYas < 30).ToList();
                dataGridView1.DataSource = liste;
            }

            if (radioButton9.Checked==true)
            {
                List<TBLARAÇLAR> liste = db.TBLARAÇLAR.Where(x => x.AraçVites == "Otomatik").ToList();
                dataGridView1.DataSource = liste;
            }

            if (radioButton10.Checked==true)
            {
                List<TBLARAÇLAR> liste = db.TBLARAÇLAR.Where(x => x.AraçModel > 2019).ToList();
                dataGridView1.DataSource = liste;
            }
            if (radioButton11.Checked==true)
            {
                List<TBLARAÇLAR> liste = db.TBLARAÇLAR.Where(x => x.AraçRenk == "Beyaz").ToList();
                dataGridView1.DataSource = liste;
            }

            if (radioButton12.Checked==true)
            {
                List<TBLARAÇLAR> liste = db.TBLARAÇLAR.Where(x => x.AraçFiyat > 200 && x.AraçFiyat < 300).ToList();
                dataGridView1.DataSource = liste;
            }
            if (radioButton2.Checked==true)
            {
                List<TBLMÜSTERİLER> liste = db.TBLMÜSTERİLER.Where(x => x.MüşteriSoyad == "Aloglu").ToList();
                dataGridView1.DataSource=liste;
            }
            if (radioButton13.Checked==true)
            {
              
                 List<TBLARAÇLAR> liste = db.TBLARAÇLAR.Where(x => x.AraçFiyat > 200000 && x.AraçFiyat < 400000).ToList();
                 dataGridView1.DataSource = liste;
              
            }

            if (radioButton14.Checked==true)
            {
                List<TBLARAÇLAR> liste = db.TBLARAÇLAR.Where(x => x.AraçFiyat < 300 && x.AraçRenk == "Beyaz").ToList();
                dataGridView1.DataSource = liste;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[12].Visible = false;
            }

            if (radioButton15.Checked==true)
            {
                List<TBLARAÇLAR> liste = db.TBLARAÇLAR.Where(x => x.AraçFiyat < 300000 && x.AraçRenk == "Beyaz"&&x.AraçVites=="Manuel").ToList();
                dataGridView1.DataSource = liste;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[12].Visible = false;
            }
            if (radioButton17.Checked==true)
            {
                List<TBLPERSONELLER> liste = db.TBLPERSONELLER.Where(x => x.PersonelYas > 30 && x.PersonelAd.StartsWith("E") && x.PersonelŞubeNo == 2).ToList();
                dataGridView1.DataSource = liste;   
            }

            if (radioButton16.Checked==true)
            {
                List<TBLPERSONELLER> liste = db.TBLPERSONELLER.Where(x => x.PersonelYas < 30 && x.PersonelSoyad == "Aloglu").ToList();
                dataGridView1.DataSource = liste;
            }



        }

        private void btn_menüdön_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seçim_Ekranı frm = new Seçim_Ekranı();
            frm.Show();
        }
    }
}
