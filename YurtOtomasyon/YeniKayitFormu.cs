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

namespace YurtOtomasyon
{
    public partial class YeniKayitFormu : Form
    {
        public YeniKayitFormu()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HI86LKC\\SQLEXPRESS;Initial Catalog=YurtOtomasyonu;Integrated Security=True");


        void YeniKayit()
        {
            
            baglanti.Open();

            string veri = "Insert Into Ogrenci(OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrAdres,VeliAd,VeliSoyad,VeliTelefon,VeliAdres,OdaNo) Values ('" + txtAd.Text + "','" + txtSoyad.Text + "','" + txtTC.Text + "','" + txtTelefon.Text + "','" + txtDogum.Text + "','" + txtBolum.Text + "','" + txtMail.Text + "','" + txtAdres.Text + "','" + txtVeliAd.Text + "','" + txtVeliSoyad.Text + "','" + txtVeliTelefon.Text + "','" + txtVeliAdres.Text + "','" + txtOdaNo.Text + "')";
            SqlCommand komut = new SqlCommand(veri, baglanti);
            komut.ExecuteNonQuery();

            string ogrIDKayit = "Insert Into Borclar(OgrID) Select OgrID From Ogrenci Where OgrID = (Select OgrID From Ogrenci Where OgrTC ='" + txtTC.Text + "' ); Insert Into Izinler(OgrID) Select OgrID From Ogrenci Where OgrID = (Select OgrID From Ogrenci Where OgrTC ='" + txtTC.Text + "' ); Insert Into OgrenciGiris(OgrID) Select OgrID From Ogrenci Where OgrID = (Select OgrID From Ogrenci Where OgrTC ='" + txtTC.Text + "' );";
            SqlCommand komut2 = new SqlCommand(ogrIDKayit, baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
        }

        void OdaDoldur()
        {
            baglanti.Open();
            string doldur = "Update Odalar Set KisiSayisi=KisiSayisi+1 Where OdaNo= '" + txtOdaNo.Text + "'";
            SqlCommand komutDoldur = new SqlCommand(doldur, baglanti);
            komutDoldur.ExecuteNonQuery();

            baglanti.Close();
        }

        private void btnKaydetOgrenciBilgi_MouseDown(object sender, MouseEventArgs e)
        {
            btnKaydetOgrenciBilgi.BackColor = Color.AliceBlue;
            btnKaydetOgrenciBilgi.ForeColor = SystemColors.HotTrack;
        }

        private void btnKaydetOgrenciBilgi_MouseUp(object sender, MouseEventArgs e)
        {
            btnKaydetOgrenciBilgi.BackColor = SystemColors.HotTrack;
            btnKaydetOgrenciBilgi.ForeColor = Color.AliceBlue; 
        }

        private void btnGeriYeniKayit_Click(object sender, EventArgs e)
        {
            OgrenciIslemleriFormu ogrenciIslemleriFormu = new OgrenciIslemleriFormu();
            this.Hide();
            ogrenciIslemleriFormu.Show();
        }

        private void btnGeriYeniKayit_MouseDown(object sender, MouseEventArgs e)
        {
            btnGeriYeniKayit.BackColor = SystemColors.HotTrack;
            btnGeriYeniKayit.ForeColor = Color.AliceBlue;
        }

        private void btnGeriYeniKayit_MouseUp(object sender, MouseEventArgs e)
        {
            btnGeriYeniKayit.BackColor = Color.AliceBlue;
            btnGeriYeniKayit.ForeColor = SystemColors.HotTrack;
        }

        private void btnOdaSec_MouseDown(object sender, MouseEventArgs e)
        {
            btnOdaSec.BackColor = Color.AliceBlue;
            btnOdaSec.ForeColor = SystemColors.HotTrack;
        }

        private void btnOdaSec_MouseUp(object sender, MouseEventArgs e)
        {
            btnOdaSec.BackColor = SystemColors.HotTrack;
            btnOdaSec.ForeColor = Color.AliceBlue; 
        }

        private void btnOdaSec_Click(object sender, EventArgs e)
        {
            OdaSecmeFormu odaSecmeFormu = new OdaSecmeFormu();
            this.Hide();
            odaSecmeFormu.Show();
        }

        private void btnKaydetOgrenciBilgi_Click(object sender, EventArgs e)
        {
            YeniKayit();
            OdaDoldur();
            MessageBox.Show("Öğrenci başarıyla kaydedildi!");
        }
    }
}
