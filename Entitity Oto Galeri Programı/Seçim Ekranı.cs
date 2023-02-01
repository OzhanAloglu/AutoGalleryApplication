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
    public partial class Seçim_Ekranı : Form
    {
        public Seçim_Ekranı()
        {
            InitializeComponent();
        }

        private void araçKiralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MüşteriListesi frm2 = new MüşteriListesi();
            frm2.ShowDialog();
            
        }

        private void araçSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            YeniMüşteriEkleme frm3=new YeniMüşteriEkleme();
            frm3.ShowDialog();
            
        }

        private void müşteriBilgileriGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MüşteriBilgileriGüncelle frm11 = new MüşteriBilgileriGüncelle();
            frm11.ShowDialog();
            
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonelEkleme frm4 = new PersonelEkleme();
            frm4.ShowDialog();
            
        }

        private void personelBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonelListesi frm5=new PersonelListesi();
            frm5.ShowDialog();
            

        }

        private void personelBilgiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonelGüncelle frm6 = new PersonelGüncelle();
            frm6.ShowDialog();
            

        }

        private void araçKiralamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Araçlar frm7 = new Araçlar();
            frm7.ShowDialog();
            
        }

        private void araçGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AraçGüncelle frm8 = new AraçGüncelle();
            frm8.ShowDialog();
            
        }

        private void araçSatınAlmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SatılıkAraçlar frm8 = new SatılıkAraçlar();
            frm8.ShowDialog();
            
        }

        private void kiralıkAraçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KiralıkAraçlar frm22 = new KiralıkAraçlar();
            frm22.ShowDialog();
            
        }

        private void şubelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Şubeler frm10 = new Şubeler();
            frm10.ShowDialog();
            
        }

        private void müşteriSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MüşteriSilme frm17 = new MüşteriSilme();
            frm17.ShowDialog();
        }

        private void personelSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonelSilme frm19=new PersonelSilme();
            frm19.ShowDialog(); 
        }

        private void araçSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AraçSil frm21 = new AraçSil();
            frm21.ShowDialog();
        }

        private void şubeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ŞubeEkle frm28=new ŞubeEkle();
            frm28.ShowDialog();
        }

        private void şubeGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Şube_Güncelleme frm33 = new Şube_Güncelleme();
            frm33.ShowDialog();
        }

        private void şubeSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ŞubeSilme frm34=new ŞubeSilme();
            frm34.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sözleşme frm40 = new Sözleşme();
            frm40.ShowDialog();
        }

        private void raporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RaporYazdır raporyazdır = new RaporYazdır();
            raporyazdır.Show();
        }

        private void araçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AraçEkle frm = new AraçEkle();
            frm.Show();
        }
    }
}
