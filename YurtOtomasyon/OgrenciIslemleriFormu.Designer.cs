
namespace YurtOtomasyon
{
    partial class OgrenciIslemleriFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.btnKayitSil = new System.Windows.Forms.Button();
            this.btnGeriAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnYeniKayit.Font = new System.Drawing.Font("Sitka Display", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniKayit.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnYeniKayit.Location = new System.Drawing.Point(174, 180);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(273, 103);
            this.btnYeniKayit.TabIndex = 0;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = false;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            this.btnYeniKayit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnYeniKayit_MouseDown);
            this.btnYeniKayit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnYeniKayit_MouseUp);
            // 
            // btnKayitSil
            // 
            this.btnKayitSil.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnKayitSil.Font = new System.Drawing.Font("Sitka Display", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitSil.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnKayitSil.Location = new System.Drawing.Point(174, 304);
            this.btnKayitSil.Name = "btnKayitSil";
            this.btnKayitSil.Size = new System.Drawing.Size(273, 103);
            this.btnKayitSil.TabIndex = 1;
            this.btnKayitSil.Text = "Kayıt Silme";
            this.btnKayitSil.UseVisualStyleBackColor = false;
            this.btnKayitSil.Click += new System.EventHandler(this.btnKayitSil_Click);
            this.btnKayitSil.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnKayitSil_MouseDown);
            this.btnKayitSil.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnKayitSil_MouseUp);
            // 
            // btnGeriAdmin
            // 
            this.btnGeriAdmin.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGeriAdmin.Font = new System.Drawing.Font("Sitka Display", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriAdmin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGeriAdmin.Location = new System.Drawing.Point(520, 12);
            this.btnGeriAdmin.Name = "btnGeriAdmin";
            this.btnGeriAdmin.Size = new System.Drawing.Size(89, 41);
            this.btnGeriAdmin.TabIndex = 11;
            this.btnGeriAdmin.Text = "Geri";
            this.btnGeriAdmin.UseVisualStyleBackColor = false;
            this.btnGeriAdmin.Click += new System.EventHandler(this.btnGeriAdmin_Click);
            this.btnGeriAdmin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGeriAdmin_MouseDown);
            this.btnGeriAdmin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnGeriAdmin_MouseUp);
            // 
            // OgrenciIslemleriFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(621, 586);
            this.Controls.Add(this.btnGeriAdmin);
            this.Controls.Add(this.btnKayitSil);
            this.Controls.Add(this.btnYeniKayit);
            this.Font = new System.Drawing.Font("Sitka Display", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OgrenciIslemleriFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci İşlemleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.Button btnKayitSil;
        private System.Windows.Forms.Button btnGeriAdmin;
    }
}