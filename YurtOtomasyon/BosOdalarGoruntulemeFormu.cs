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
    public partial class BosOdalarGoruntulemeFormu : Form
    {
        public BosOdalarGoruntulemeFormu()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HI86LKC\\SQLEXPRESS;Initial Catalog=YurtOtomasyonu;Integrated Security=True");

        private void gridDoldurBosOdalar()
        {
            baglanti.Open();
            string veri = "Select * From Odalar Where KisiSayisi<4";
            SqlCommand komut = new SqlCommand(veri, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwBosOdalar.DataSource = dt;
            baglanti.Close();
        }

        private void btnGeriBosOdalar_Click(object sender, EventArgs e)
        {
            OdalarFormu odalarFormu = new OdalarFormu();
            this.Hide();
            odalarFormu.Show();
        }

        private void btnGeriBosOdalar_MouseDown(object sender, MouseEventArgs e)
        {
            btnGeriBosOdalar.BackColor = SystemColors.HotTrack;
            btnGeriBosOdalar.ForeColor = Color.AliceBlue;
        }

        private void btnGeriBosOdalar_MouseUp(object sender, MouseEventArgs e)
        {
            btnGeriBosOdalar.BackColor = Color.AliceBlue; 
            btnGeriBosOdalar.ForeColor = SystemColors.HotTrack;
        }

        private void BosOdalarGoruntulemeFormu_Load(object sender, EventArgs e)
        {
            gridDoldurBosOdalar();
        }
    }
}
