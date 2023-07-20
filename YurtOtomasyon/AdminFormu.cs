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
    public partial class AdminFormu : Form
    {

        
        public AdminFormu()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HI86LKC\\SQLEXPRESS;Initial Catalog=YurtOtomasyonu;Integrated Security=True");

        private void BorcGoruntuleme()
        {
            baglanti.Open();
            string veri = "Select * From Borclar";
            SqlCommand komut = new SqlCommand(veri, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwBorclar.DataSource = dt;
            baglanti.Close();
        }

        private void IzinGoruntuleme()
        {
            baglanti.Open();
            string veri = "Select * From Izinler Where IzinKabul=1";
            SqlCommand komut = new SqlCommand(veri, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwIzinler.DataSource = dt;
            baglanti.Close();
        }
        private void btnOgrenciİsleri_MouseDown(object sender, MouseEventArgs e)
        {
            btnOgrenciİsleri.BackColor = Color.AliceBlue;
            btnOgrenciİsleri.ForeColor = SystemColors.HotTrack;
        }

        private void btnOgrenciİsleri_MouseUp(object sender, MouseEventArgs e)
        {
            btnOgrenciİsleri.BackColor = SystemColors.HotTrack;
            btnOgrenciİsleri.ForeColor = Color.AliceBlue;
        }

        private void btnOdalar_MouseDown(object sender, MouseEventArgs e)
        {
            btnOdalar.BackColor = Color.AliceBlue;
            btnOdalar.ForeColor = SystemColors.HotTrack;
        }

        private void btnOdalar_MouseUp(object sender, MouseEventArgs e)
        {
            btnOdalar.BackColor = SystemColors.HotTrack;
            btnOdalar.ForeColor = Color.AliceBlue;
        }

        private void btnIzinIslemleri_MouseDown(object sender, MouseEventArgs e)
        {
            btnIzinIslemleri.BackColor = Color.AliceBlue;
            btnIzinIslemleri.ForeColor = SystemColors.HotTrack;
        }

        private void btnIzinIslemleri_MouseUp(object sender, MouseEventArgs e)
        {
            btnIzinIslemleri.BackColor = SystemColors.HotTrack;
            btnIzinIslemleri.ForeColor = Color.AliceBlue;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToShortTimeString();
        }

        private void AdminFormu_Load(object sender, EventArgs e)
        {
            timerSaat.Start();
            BorcGoruntuleme();
            IzinGoruntuleme();
        }


        private void btnCikisAdmin_Click(object sender, EventArgs e)
        {
            GirisFormu girisFormu = new GirisFormu();
            this.Hide();
            girisFormu.Show();
        }

        private void btnOgrenciİsleri_Click(object sender, EventArgs e)
        {
            OgrenciIslemleriFormu ogrenciIslemleriFormu = new OgrenciIslemleriFormu();
            ogrenciIslemleriFormu.Show();
            this.Hide();
        }

        private void btnCikisAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            btnCikisAdmin.BackColor = SystemColors.HotTrack;
            btnCikisAdmin.ForeColor = Color.AliceBlue;
        }

        private void btnCikisAdmin_MouseUp(object sender, MouseEventArgs e)
        {
            btnCikisAdmin.BackColor = Color.AliceBlue;
            btnCikisAdmin.ForeColor = SystemColors.HotTrack;
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            OdalarFormu odalarFormu = new OdalarFormu();
            odalarFormu.Show();
            this.Hide();
        }

        private void btnIzinIslemleri_Click(object sender, EventArgs e)
        {
            IzinIslemleriFormu izinIslemleriFormu = new IzinIslemleriFormu();
            izinIslemleriFormu.Show();
            this.Hide();
        }
    }
}
