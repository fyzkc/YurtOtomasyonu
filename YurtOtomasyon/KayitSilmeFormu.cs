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
    public partial class KayitSilmeFormu : Form
    {
        public KayitSilmeFormu()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HI86LKC\\SQLEXPRESS;Initial Catalog=YurtOtomasyonu;Integrated Security=True");


        private void gridDoldur()
        {
            baglanti.Open();
            string veri = "Select * From Ogrenci";
            SqlCommand komut = new SqlCommand(veri, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwKayitSil.DataSource = dt;
            baglanti.Close();

        }
        private void KayitSil()
        {
            string id = dgwKayitSil.CurrentRow.Cells[0].Value.ToString();
            string odaNo = dgwKayitSil.CurrentRow.Cells[13].Value.ToString();
            baglanti.Open();
            string sil = "Delete From Ogrenci Where OgrID = @id";
            string odaBosalt = "Update Odalar Set KisiSayisi = KisiSayisi-1 Where OdaNo = @odaNo";
            SqlCommand komut = new SqlCommand(sil, baglanti);
            SqlCommand komut2 = new SqlCommand(odaBosalt, baglanti);
            komut.Parameters.AddWithValue("@id", id);
            komut2.Parameters.AddWithValue("@odaNo", odaNo);
            komut.ExecuteNonQuery();
            komut2.ExecuteNonQuery();

            

            baglanti.Close();
        }

        private void btnGeriKayitSil_Click(object sender, EventArgs e)
        {
            OgrenciIslemleriFormu ogrenciIslemleriFormu = new OgrenciIslemleriFormu();
            this.Hide();
            ogrenciIslemleriFormu.Show();
        }

        private void btnGeriKayitSil_MouseDown(object sender, MouseEventArgs e)
        {
            btnGeriKayitSil.BackColor = SystemColors.HotTrack;
            btnGeriKayitSil.ForeColor = Color.AliceBlue;
        }

        private void btnGeriKayitSil_MouseUp(object sender, MouseEventArgs e)
        {
            btnGeriKayitSil.BackColor = Color.AliceBlue;
            btnGeriKayitSil.ForeColor = SystemColors.HotTrack;
        }

        private void btnKayitSil_MouseDown(object sender, MouseEventArgs e)
        {
            btnKayitSil.BackColor = Color.AliceBlue;
            btnKayitSil.ForeColor = SystemColors.HotTrack;
        }

        private void btnKayitSil_MouseUp(object sender, MouseEventArgs e)
        {
            btnKayitSil.BackColor = SystemColors.HotTrack;
            btnKayitSil.ForeColor = Color.AliceBlue;
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            string mesaj = "Öğrencinin kaydını silmek istediğinizden emin misiniz?";
            string caption = "Uyarı!";
            var sonuc = MessageBox.Show(mesaj, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(sonuc==DialogResult.Yes)
            {
                KayitSil();
                MessageBox.Show("Öğrencinin kaydı başarıyla silindi!");
                gridDoldur();
            }
        }

        private void KayitSilmeFormu_Load(object sender, EventArgs e)
        {
            gridDoldur();
        }
    }
}
