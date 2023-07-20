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
    public partial class UyeOlFormu : Form
    {
        public UyeOlFormu()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HI86LKC\\SQLEXPRESS;Initial Catalog=YurtOtomasyonu;Integrated Security=True");
        
        private void UyeOl()
        {
            baglanti.Close();
            baglanti.Open();
            string veri = "Update OgrenciGiris Set KullaniciAd= '" + txtUyeOlTC.Text + "', Sifre = '" + txtUyeOlSifre.Text + "' Where OgrID = (Select OgrID From Ogrenci Where OgrTC = '" + txtUyeOlTC.Text + "') ";
            SqlCommand komut = new SqlCommand(veri, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnCikisUyeOl_Click(object sender, EventArgs e)
        {
            GirisFormu giris = new GirisFormu();
            this.Hide();
            giris.Show();
        }

        private void btnCikisUyeOl_MouseDown(object sender, MouseEventArgs e)
        {
            btnCikisUyeOl.BackColor = SystemColors.HotTrack;
            btnCikisUyeOl.ForeColor = Color.AliceBlue;
        }

        private void btnCikisUyeOl_MouseUp(object sender, MouseEventArgs e)
        {
            btnCikisUyeOl.BackColor = Color.AliceBlue;
            btnCikisUyeOl.ForeColor = SystemColors.HotTrack; 
        }

        private void btnKaydetUyeOl_MouseDown(object sender, MouseEventArgs e)
        {
            btnKaydetUyeOl.BackColor = Color.AliceBlue;
            btnKaydetUyeOl.ForeColor = SystemColors.HotTrack;
        }

        private void btnKaydetUyeOl_MouseUp(object sender, MouseEventArgs e)
        {
            btnKaydetUyeOl.BackColor = SystemColors.HotTrack;
            btnKaydetUyeOl.ForeColor = Color.AliceBlue;
        }

        private void btnKaydetUyeOl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kontrol = "Select * From Ogrenci Where OgrTC = '" + txtUyeOlTC.Text + "' ";
            SqlCommand komut = new SqlCommand(kontrol, baglanti);
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            if(dr.Read())
            {
                UyeOl();
                MessageBox.Show("Üye kaydınız başarıyla gerçekleşti. Giriş yapmak için tekrar çıkış yapınız.");
            }
            else
            {
                MessageBox.Show("Girdiğiniz TC numarasına ait kayıt bulunamamaktadır.");
            }

            baglanti.Close();
        }
    }
}
