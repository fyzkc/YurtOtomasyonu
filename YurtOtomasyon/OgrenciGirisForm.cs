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
    public partial class OgrenciGirisForm : Form
    {
        public OgrenciGirisForm()
        {
            InitializeComponent();
        }

        private void btnCikisOgrenci_Click(object sender, EventArgs e)
        {
            GirisFormu girisFormu = new GirisFormu();
            this.Hide();
            girisFormu.Show();
        }

        private void btnCikisOgrenci_MouseDown(object sender, MouseEventArgs e)
        {
            btnCikisOgrenci.BackColor = SystemColors.HotTrack;
            btnCikisOgrenci.ForeColor = Color.AliceBlue;
        }

        private void btnCikisOgrenci_MouseUp(object sender, MouseEventArgs e)
        {
            btnCikisOgrenci.BackColor = Color.AliceBlue;
            btnCikisOgrenci.ForeColor = SystemColors.HotTrack;
        }

        private void btnOgrenciIzin_MouseDown(object sender, MouseEventArgs e)
        {
            btnOgrenciIzin.BackColor = Color.AliceBlue;
            btnOgrenciIzin.ForeColor = SystemColors.HotTrack;
        }

        private void btnOgrenciIzin_MouseUp(object sender, MouseEventArgs e)
        {
            btnOgrenciIzin.BackColor = SystemColors.HotTrack;
            btnOgrenciIzin.ForeColor = Color.AliceBlue;
        }

        

        

        private void btnOgrenciIzin_Click(object sender, EventArgs e)
        {
            IzinAlmaFormu ızinAlmaFormu = new IzinAlmaFormu();
            ızinAlmaFormu.Show();
            this.Hide();
        }

        
    }
}
