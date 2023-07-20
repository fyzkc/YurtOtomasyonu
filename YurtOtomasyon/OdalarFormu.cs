using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtOtomasyon
{
    public partial class OdalarFormu : Form
    {
        public OdalarFormu()
        {
            InitializeComponent();
        }

        private void btnGeriOdalar_Click(object sender, EventArgs e)
        {
            AdminFormu adminFormu = new AdminFormu();
            adminFormu.Show();
            this.Hide();
        }

        private void btnGeriOdalar_MouseDown(object sender, MouseEventArgs e)
        {
            btnGeriOdalar.BackColor = SystemColors.HotTrack;
            btnGeriOdalar.ForeColor = Color.AliceBlue;
        }

        private void btnGeriOdalar_MouseUp(object sender, MouseEventArgs e)
        {
            btnGeriOdalar.BackColor = Color.AliceBlue; 
            btnGeriOdalar.ForeColor = SystemColors.HotTrack;
        }

        private void btnButunKayitlar_MouseDown(object sender, MouseEventArgs e)
        {
            btnButunKayitlar.BackColor = Color.AliceBlue;
            btnButunKayitlar.ForeColor = SystemColors.HotTrack;
        }

        private void btnButunKayitlar_MouseUp(object sender, MouseEventArgs e)
        {
            btnButunKayitlar.BackColor = SystemColors.HotTrack;
            btnButunKayitlar.ForeColor = Color.AliceBlue;
        }

        private void btnBosOdalar_MouseDown(object sender, MouseEventArgs e)
        {
            btnBosOdalar.BackColor = Color.AliceBlue;
            btnBosOdalar.ForeColor = SystemColors.HotTrack;
        }

        private void btnBosOdalar_MouseUp(object sender, MouseEventArgs e)
        {
            btnBosOdalar.BackColor = SystemColors.HotTrack;
            btnBosOdalar.ForeColor = Color.AliceBlue;
        }

        private void btnButunKayitlar_Click(object sender, EventArgs e)
        {
            ButunKayitlarGoruntulemeFormu bkg = new ButunKayitlarGoruntulemeFormu();
            this.Hide();
            bkg.Show();
        }

        private void btnBosOdalar_Click(object sender, EventArgs e)
        {
            BosOdalarGoruntulemeFormu bog = new BosOdalarGoruntulemeFormu();
            this.Hide();
            bog.Show();
        }

        
    }
}
