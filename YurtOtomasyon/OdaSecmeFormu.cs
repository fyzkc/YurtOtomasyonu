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
    public partial class OdaSecmeFormu : Form
    {
        public OdaSecmeFormu()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HI86LKC\\SQLEXPRESS;Initial Catalog=YurtOtomasyonu;Integrated Security=True");
        

        void BosOdalarGoster()
        {
            baglanti.Open();
            string veri = "Select * From Odalar Where KisiSayisi<4";
            SqlCommand komut = new SqlCommand(veri,baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwBosOdaSec.DataSource = dt;
            baglanti.Close();
        }

        private void btnGeriBosOdaSec_Click(object sender, EventArgs e)
        {
            YeniKayitFormu yeniKayitFormu = new YeniKayitFormu();
            this.Hide();
            yeniKayitFormu.Show();
        }

        private void btnGeriBosOdaSec_MouseDown(object sender, MouseEventArgs e)
        {
            btnGeriBosOdaSec.BackColor = SystemColors.HotTrack;
            btnGeriBosOdaSec.ForeColor = Color.AliceBlue;
        }

        private void btnGeriBosOdaSec_MouseUp(object sender, MouseEventArgs e)
        {
            btnGeriBosOdaSec.BackColor = Color.AliceBlue;
            btnGeriBosOdaSec.ForeColor = SystemColors.HotTrack; 
        }

        private void btnBosOdaSec_MouseDown(object sender, MouseEventArgs e)
        {
            btnBosOdaSec.BackColor = Color.AliceBlue;
            btnBosOdaSec.ForeColor = SystemColors.HotTrack;
        }

        private void btnBosOdaSec_MouseUp(object sender, MouseEventArgs e)
        {
            btnBosOdaSec.BackColor = SystemColors.HotTrack;
            btnBosOdaSec.ForeColor = Color.AliceBlue; 
        }

        private void OdaSecmeFormu_Load(object sender, EventArgs e)
        {
            BosOdalarGoster();
        }

        private void btnBosOdaSec_Click(object sender, EventArgs e)
        {
            YeniKayitFormu yenikayit = new YeniKayitFormu();
            this.Hide();
            yenikayit.Show();
            yenikayit.txtOdaNo.Text = dgwBosOdaSec.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
