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
    public partial class IzinIslemleriFormu : Form
    {
        public IzinIslemleriFormu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HI86LKC\\SQLEXPRESS;Initial Catalog=YurtOtomasyonu;Integrated Security=True");

        private void IzinTalebiGoruntule()
        {
            baglanti.Open();
            string veri = "Select * From Izinler Where IzinKabul=0";
            SqlCommand komut = new SqlCommand(veri, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwIzinTalepleri.DataSource = dt;
            baglanti.Close();
        }

        private void btnGeriIzinler_Click(object sender, EventArgs e)
        {
            AdminFormu adminFormu = new AdminFormu();
            adminFormu.Show();
            this.Hide();
        }

        private void btnGeriIzinler_MouseDown(object sender, MouseEventArgs e)
        {
            btnGeriIzinler.BackColor = SystemColors.HotTrack;
            btnGeriIzinler.ForeColor = Color.AliceBlue;
        }

        private void btnGeriIzinler_MouseUp(object sender, MouseEventArgs e)
        {
            btnGeriIzinler.BackColor = Color.AliceBlue;
            btnGeriIzinler.ForeColor = SystemColors.HotTrack;
        }

        private void btnIzinKabul_MouseDown(object sender, MouseEventArgs e)
        {
            btnIzinKabul.BackColor = SystemColors.HotTrack;
            btnIzinKabul.ForeColor = Color.AliceBlue;
        }

        private void btnIzinKabul_MouseUp(object sender, MouseEventArgs e)
        {
            btnIzinKabul.BackColor = Color.AliceBlue;
            btnIzinKabul.ForeColor = SystemColors.HotTrack;
        }

        private void btnIzinRed_MouseDown(object sender, MouseEventArgs e)
        {
            btnIzinRed.BackColor = SystemColors.HotTrack;
            btnIzinRed.ForeColor = Color.AliceBlue;
        }

        private void btnIzinRed_MouseUp(object sender, MouseEventArgs e)
        {
            btnIzinRed.BackColor = Color.AliceBlue;
            btnIzinRed.ForeColor = SystemColors.HotTrack;
        }

        private void IzinIslemleriFormu_Load(object sender, EventArgs e)
        {
            IzinTalebiGoruntule();
        }

        private void btnIzinKabul_Click(object sender, EventArgs e)
        {
            string id = dgwIzinTalepleri.CurrentRow.Cells[0].Value.ToString();
            baglanti.Open();
            string veri = "Update Izinler Set IzinKabul=1 Where OgrID = @id";
            SqlCommand komut = new SqlCommand(veri, baglanti);
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            IzinTalebiGoruntule();
        }

        private void btnIzinRed_Click(object sender, EventArgs e)
        {
            string id = dgwIzinTalepleri.CurrentRow.Cells[0].Value.ToString();
            baglanti.Open();
            string sil = "Delete From Izinler Where OgrID = @id";
            SqlCommand komut = new SqlCommand(sil, baglanti);
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
    }
}
