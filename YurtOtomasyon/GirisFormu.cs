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
    public partial class GirisFormu : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HI86LKC\\SQLEXPRESS;Initial Catalog=YurtOtomasyonu;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand komut;

        
        public GirisFormu()
        {
            InitializeComponent();
        }

        public string kullaniciAdOgr;
        public string sifreOgr;

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            
            komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select * from AdminGiris where KullaniciAd = '" + txtKullaniciAdi.Text + "'And Sifre = '" + txtSifre.Text + "'";
            dr = komut.ExecuteReader();
            if(dr.Read())
            {
                AdminFormu adminFormu = new AdminFormu();
                this.Hide();
                adminFormu.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }
            baglanti.Close();

            
        }

        private void btnOgrenciGiris_Click(object sender, EventArgs e)
        {
            
            
            baglanti.Open();
            string girisKontrol = "Select * From OgrenciGiris Where KullaniciAd = '"+ txtKullaniciAdi .Text+ "' And Sifre = '"+ txtSifre.Text + "' ";
            SqlCommand komut = new SqlCommand(girisKontrol, baglanti);
            dr = komut.ExecuteReader();
            if(dr.Read())
            {
                OgrenciGirisForm ogrGiris = new OgrenciGirisForm();
                kullaniciAdOgr = txtKullaniciAdi.Text;
                sifreOgr = txtSifre.Text;
                ogrGiris.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }
            baglanti.Close();

            //string kullaniciAdOgr = txtKullaniciAdi.Text;
            //string SifreOgr = txtSifre.Text;

        }

        private void btnAdminGiris_MouseDown(object sender, MouseEventArgs e)
        {
            btnAdminGiris.BackColor = Color.AliceBlue;
            btnAdminGiris.ForeColor = SystemColors.HotTrack;
        }

        private void btnAdminGiris_MouseUp(object sender, MouseEventArgs e)
        {
            btnAdminGiris.BackColor = SystemColors.HotTrack;
            btnAdminGiris.ForeColor = Color.AliceBlue;
        }

        private void btnOgrenciGiris_MouseDown(object sender, MouseEventArgs e)
        {
            btnOgrenciGiris.BackColor = Color.AliceBlue;
            btnOgrenciGiris.ForeColor = SystemColors.HotTrack;
        }

        private void btnOgrenciGiris_MouseUp(object sender, MouseEventArgs e)
        {
            btnOgrenciGiris.BackColor = SystemColors.HotTrack;
            btnOgrenciGiris.ForeColor = Color.AliceBlue;
        }

        private void btnUyeOl_MouseDown(object sender, MouseEventArgs e)
        {
            btnUyeOl.BackColor = Color.AliceBlue;
            btnUyeOl.ForeColor = SystemColors.HotTrack;
        }

        private void btnUyeOl_MouseUp(object sender, MouseEventArgs e)
        {
            btnUyeOl.BackColor = SystemColors.HotTrack;
            btnUyeOl.ForeColor = Color.AliceBlue;
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            UyeOlFormu uyeol = new UyeOlFormu();
            this.Hide();
            uyeol.Show();
        }

        
    }
}
