using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace Entitity_Oto_Galeri_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
       OtoGaleriOtomasyonuEntities1 db=new OtoGaleriOtomasyonuEntities1();

        private void btnGiriş_Click(object sender, EventArgs e)
        {

            var m = db.TBLKULLANICILAR.Where(x => x.KullanıcıID == txtKullanıcıAdı.Text && x.KullanıcıŞifre == txtŞifre.Text).SingleOrDefault();

            if (m==null)
            {
                MessageBox.Show("Hatalı giriş.");
            }

            else if (m!=null)
            {
                Seçim_Ekranı frm = new Seçim_Ekranı();
                frm.ShowDialog();
                this.Hide();
            }
           
            
        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            TBLKULLANICILAR tbl=new TBLKULLANICILAR();
            tbl.KullanıcıID = txtMüsteriKayıtId.Text;

            if (txtMüsteriKayıtSifre.Text==txtMüsteriKayıtSifreTekrar.Text)
            {
                tbl.KullanıcıŞifre = txtMüsteriKayıtSifre.Text;
                db.TBLKULLANICILAR.Add(tbl);
                db.SaveChanges();
                MessageBox.Show("Kullanıcı kaydedildi.");
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor.");
            }
        }

       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtŞifre.UseSystemPasswordChar = true;
            if (checkBox1.CheckState==CheckState.Checked)
            {
                txtŞifre.UseSystemPasswordChar = true;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState==CheckState.Unchecked)
            {
                txtŞifre.UseSystemPasswordChar = false;
                checkBox1.Text = "Göster";
            }
        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
