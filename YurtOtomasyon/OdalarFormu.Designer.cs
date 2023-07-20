
namespace YurtOtomasyon
{
    partial class OdalarFormu
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
            this.btnGeriOdalar = new System.Windows.Forms.Button();
            this.btnBosOdalar = new System.Windows.Forms.Button();
            this.btnButunKayitlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGeriOdalar
            // 
            this.btnGeriOdalar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGeriOdalar.Font = new System.Drawing.Font("Sitka Display", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriOdalar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGeriOdalar.Location = new System.Drawing.Point(520, 12);
            this.btnGeriOdalar.Name = "btnGeriOdalar";
            this.btnGeriOdalar.Size = new System.Drawing.Size(89, 41);
            this.btnGeriOdalar.TabIndex = 12;
            this.btnGeriOdalar.Text = "Geri";
            this.btnGeriOdalar.UseVisualStyleBackColor = false;
            this.btnGeriOdalar.Click += new System.EventHandler(this.btnGeriOdalar_Click);
            this.btnGeriOdalar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGeriOdalar_MouseDown);
            this.btnGeriOdalar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnGeriOdalar_MouseUp);
            // 
            // btnBosOdalar
            // 
            this.btnBosOdalar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBosOdalar.Font = new System.Drawing.Font("Sitka Display", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBosOdalar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnBosOdalar.Location = new System.Drawing.Point(174, 304);
            this.btnBosOdalar.Name = "btnBosOdalar";
            this.btnBosOdalar.Size = new System.Drawing.Size(273, 103);
            this.btnBosOdalar.TabIndex = 14;
            this.btnBosOdalar.Text = "Boş Odaları Görüntüle";
            this.btnBosOdalar.UseVisualStyleBackColor = false;
            this.btnBosOdalar.Click += new System.EventHandler(this.btnBosOdalar_Click);
            this.btnBosOdalar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBosOdalar_MouseDown);
            this.btnBosOdalar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnBosOdalar_MouseUp);
            // 
            // btnButunKayitlar
            // 
            this.btnButunKayitlar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnButunKayitlar.Font = new System.Drawing.Font("Sitka Display", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnButunKayitlar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnButunKayitlar.Location = new System.Drawing.Point(174, 180);
            this.btnButunKayitlar.Name = "btnButunKayitlar";
            this.btnButunKayitlar.Size = new System.Drawing.Size(273, 103);
            this.btnButunKayitlar.TabIndex = 13;
            this.btnButunKayitlar.Text = "Tüm Kayıtları Görüntüle";
            this.btnButunKayitlar.UseVisualStyleBackColor = false;
            this.btnButunKayitlar.Click += new System.EventHandler(this.btnButunKayitlar_Click);
            this.btnButunKayitlar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnButunKayitlar_MouseDown);
            this.btnButunKayitlar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnButunKayitlar_MouseUp);
            // 
            // OdalarFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(621, 586);
            this.Controls.Add(this.btnBosOdalar);
            this.Controls.Add(this.btnButunKayitlar);
            this.Controls.Add(this.btnGeriOdalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OdalarFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odalar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeriOdalar;
        private System.Windows.Forms.Button btnBosOdalar;
        private System.Windows.Forms.Button btnButunKayitlar;
    }
}