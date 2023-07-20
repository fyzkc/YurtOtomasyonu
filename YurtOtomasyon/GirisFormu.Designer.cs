
namespace YurtOtomasyon
{
    partial class GirisFormu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.btnOgrenciGiris = new System.Windows.Forms.Button();
            this.btnUyeOl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(289, 228);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(189, 30);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(289, 264);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(189, 30);
            this.txtSifre.TabIndex = 1;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Sitka Display", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(143, 226);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(146, 33);
            this.lblKullaniciAdi.TabIndex = 2;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Sitka Display", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSifre.Location = new System.Drawing.Point(143, 262);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(63, 33);
            this.lblSifre.TabIndex = 3;
            this.lblSifre.Text = "Şifre";
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdminGiris.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnAdminGiris.Location = new System.Drawing.Point(149, 321);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(134, 39);
            this.btnAdminGiris.TabIndex = 4;
            this.btnAdminGiris.Text = "Admin Girişi";
            this.btnAdminGiris.UseVisualStyleBackColor = false;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            this.btnAdminGiris.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAdminGiris_MouseDown);
            this.btnAdminGiris.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAdminGiris_MouseUp);
            // 
            // btnOgrenciGiris
            // 
            this.btnOgrenciGiris.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOgrenciGiris.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnOgrenciGiris.Location = new System.Drawing.Point(344, 321);
            this.btnOgrenciGiris.Name = "btnOgrenciGiris";
            this.btnOgrenciGiris.Size = new System.Drawing.Size(134, 39);
            this.btnOgrenciGiris.TabIndex = 5;
            this.btnOgrenciGiris.Text = "Öğrenci Girişi";
            this.btnOgrenciGiris.UseVisualStyleBackColor = false;
            this.btnOgrenciGiris.Click += new System.EventHandler(this.btnOgrenciGiris_Click);
            this.btnOgrenciGiris.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnOgrenciGiris_MouseDown);
            this.btnOgrenciGiris.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnOgrenciGiris_MouseUp);
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUyeOl.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnUyeOl.Location = new System.Drawing.Point(246, 391);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Size = new System.Drawing.Size(134, 39);
            this.btnUyeOl.TabIndex = 6;
            this.btnUyeOl.Text = "Üye Ol";
            this.btnUyeOl.UseVisualStyleBackColor = false;
            this.btnUyeOl.Click += new System.EventHandler(this.btnUyeOl_Click);
            this.btnUyeOl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnUyeOl_MouseDown);
            this.btnUyeOl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnUyeOl_MouseUp);
            // 
            // GirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(621, 586);
            this.Controls.Add(this.btnUyeOl);
            this.Controls.Add(this.btnOgrenciGiris);
            this.Controls.Add(this.btnAdminGiris);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Font = new System.Drawing.Font("Sitka Display", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "GirisFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Button btnUyeOl;
        public System.Windows.Forms.TextBox txtKullaniciAdi;
        public System.Windows.Forms.TextBox txtSifre;
        public System.Windows.Forms.Button btnAdminGiris;
        public System.Windows.Forms.Button btnOgrenciGiris;
    }
}

