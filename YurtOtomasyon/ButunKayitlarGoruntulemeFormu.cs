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
    public partial class ButunKayitlarGoruntulemeFormu : Form
    {
        public ButunKayitlarGoruntulemeFormu()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HI86LKC\\SQLEXPRESS;Initial Catalog=YurtOtomasyonu;Integrated Security=True");
        
        private void gridDoldurButunKayitlar()
        {
            baglanti.Open();
            string veri = "Select * From Ogrenci";
            SqlCommand komut = new SqlCommand(veri, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwButunKayitlar.DataSource = dt;
            baglanti.Close();
        }

        private void btnGeriButunKayitlar_Click(object sender, EventArgs e)
        {
            OdalarFormu odalarFormu = new OdalarFormu();
            this.Hide();
            odalarFormu.Show();
        }

        private void btnGeriButunKayitlar_MouseDown(object sender, MouseEventArgs e)
        {
            btnGeriButunKayitlar.BackColor = SystemColors.HotTrack;
            btnGeriButunKayitlar.ForeColor = Color.AliceBlue;
        }

        private void btnGeriButunKayitlar_MouseUp(object sender, MouseEventArgs e)
        {
            btnGeriButunKayitlar.BackColor = Color.AliceBlue; 
            btnGeriButunKayitlar.ForeColor = SystemColors.HotTrack;
        }

        private void ButunKayitlarGoruntulemeFormu_Load(object sender, EventArgs e)
        {
            gridDoldurButunKayitlar();
        }
    }
}
