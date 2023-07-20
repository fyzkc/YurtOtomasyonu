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
    public partial class IzinAlmaFormu : Form
    {
        public IzinAlmaFormu()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HI86LKC\\SQLEXPRESS;Initial Catalog=YurtOtomasyonu;Integrated Security=True");

        private void btnGeriOgrIzinAlma_Click(object sender, EventArgs e)
        {
            OgrenciGirisForm ogrGiris = new OgrenciGirisForm();
            this.Hide();
            ogrGiris.Show();
        }

        private void btnGeriOgrIzinAlma_MouseDown(object sender, MouseEventArgs e)
        {
            btnGeriOgrIzinAlma.BackColor = SystemColors.HotTrack;
            btnGeriOgrIzinAlma.ForeColor = Color.AliceBlue;
        }

        private void btnGeriOgrIzinAlma_MouseUp(object sender, MouseEventArgs e)
        {
            btnGeriOgrIzinAlma.BackColor = Color.AliceBlue; 
            btnGeriOgrIzinAlma.ForeColor = SystemColors.HotTrack;
        }

        private void btnIzinAlmaTalebi_MouseDown(object sender, MouseEventArgs e)
        {
            btnIzinAlmaTalebi.BackColor = Color.AliceBlue;
            btnIzinAlmaTalebi.ForeColor = SystemColors.HotTrack;
        }

        private void btnIzinAlmaTalebi_MouseUp(object sender, MouseEventArgs e)
        {
            btnIzinAlmaTalebi.BackColor = SystemColors.HotTrack;
            btnIzinAlmaTalebi.ForeColor = Color.AliceBlue; 
        }

        private void btnIzinAlmaTalebi_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            string veri = "Update Izinler Set IzinKabul=0 , CikisTarih = '" + dtpCikisTarihi.Value.ToString() + "', GirisTarih = '" + dtpGirisTarihi.Value.ToString() + "', Adres = '" + txtIzinAdresi.Text + "' Where OgrID = (Select OgrID From OgrenciGiris Where KullaniciAd = '"+txtIzinAlTC.Text+"')";
            SqlCommand komut = new SqlCommand(veri, baglanti);
            komut.ExecuteNonQuery();

            MessageBox.Show("İzin talebiniz alınmıştır.");

            baglanti.Close();



        }
    }
}
