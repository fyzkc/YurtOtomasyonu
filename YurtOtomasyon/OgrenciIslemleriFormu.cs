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
    public partial class OgrenciIslemleriFormu : Form
    {
        public OgrenciIslemleriFormu()
        {
            InitializeComponent();
        }

        private void btnGeriAdmin_Click(object sender, EventArgs e)
        {
            AdminFormu adminFormu = new AdminFormu();
            adminFormu.Show();
            this.Hide();
        }

        private void btnYeniKayit_MouseDown(object sender, MouseEventArgs e)
        {
            btnYeniKayit.BackColor = Color.AliceBlue;
            btnYeniKayit.ForeColor = SystemColors.HotTrack;
        }

        private void btnYeniKayit_MouseUp(object sender, MouseEventArgs e)
        {
            btnYeniKayit.BackColor = SystemColors.HotTrack;
            btnYeniKayit.ForeColor = Color.AliceBlue;
        }

        private void btnGeriAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            btnGeriAdmin.BackColor = SystemColors.HotTrack;
            btnGeriAdmin.ForeColor = Color.AliceBlue;
        }

        private void btnGeriAdmin_MouseUp(object sender, MouseEventArgs e)
        {
            btnGeriAdmin.BackColor = Color.AliceBlue;
            btnGeriAdmin.ForeColor = SystemColors.HotTrack;
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

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            YeniKayitFormu yeniKayitFormu = new YeniKayitFormu();
            yeniKayitFormu.Show();
            this.Hide();
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            KayitSilmeFormu kayitSilmeFormu = new KayitSilmeFormu();
            kayitSilmeFormu.Show();
            this.Hide();
        }
    }
}
