
namespace YurtOtomasyon
{
    partial class IzinIslemleriFormu
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
            this.dgwIzinTalepleri = new System.Windows.Forms.DataGridView();
            this.lblIzinTalepleri = new System.Windows.Forms.Label();
            this.btnIzinKabul = new System.Windows.Forms.Button();
            this.btnIzinRed = new System.Windows.Forms.Button();
            this.btnGeriIzinler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIzinTalepleri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwIzinTalepleri
            // 
            this.dgwIzinTalepleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIzinTalepleri.Location = new System.Drawing.Point(25, 62);
            this.dgwIzinTalepleri.Name = "dgwIzinTalepleri";
            this.dgwIzinTalepleri.RowHeadersWidth = 56;
            this.dgwIzinTalepleri.RowTemplate.Height = 24;
            this.dgwIzinTalepleri.Size = new System.Drawing.Size(622, 588);
            this.dgwIzinTalepleri.TabIndex = 0;
            // 
            // lblIzinTalepleri
            // 
            this.lblIzinTalepleri.AutoSize = true;
            this.lblIzinTalepleri.Font = new System.Drawing.Font("Sitka Display", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIzinTalepleri.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblIzinTalepleri.Location = new System.Drawing.Point(18, 9);
            this.lblIzinTalepleri.Name = "lblIzinTalepleri";
            this.lblIzinTalepleri.Size = new System.Drawing.Size(187, 43);
            this.lblIzinTalepleri.TabIndex = 1;
            this.lblIzinTalepleri.Text = "İzin Talepleri";
            // 
            // btnIzinKabul
            // 
            this.btnIzinKabul.BackColor = System.Drawing.Color.AliceBlue;
            this.btnIzinKabul.Font = new System.Drawing.Font("Sitka Display", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIzinKabul.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnIzinKabul.Location = new System.Drawing.Point(664, 521);
            this.btnIzinKabul.Name = "btnIzinKabul";
            this.btnIzinKabul.Size = new System.Drawing.Size(175, 56);
            this.btnIzinKabul.TabIndex = 2;
            this.btnIzinKabul.Text = "Kabul Et";
            this.btnIzinKabul.UseVisualStyleBackColor = false;
            this.btnIzinKabul.Click += new System.EventHandler(this.btnIzinKabul_Click);
            this.btnIzinKabul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnIzinKabul_MouseDown);
            this.btnIzinKabul.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnIzinKabul_MouseUp);
            // 
            // btnIzinRed
            // 
            this.btnIzinRed.BackColor = System.Drawing.Color.AliceBlue;
            this.btnIzinRed.Font = new System.Drawing.Font("Sitka Display", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIzinRed.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnIzinRed.Location = new System.Drawing.Point(664, 594);
            this.btnIzinRed.Name = "btnIzinRed";
            this.btnIzinRed.Size = new System.Drawing.Size(175, 56);
            this.btnIzinRed.TabIndex = 3;
            this.btnIzinRed.Text = "Reddet";
            this.btnIzinRed.UseVisualStyleBackColor = false;
            this.btnIzinRed.Click += new System.EventHandler(this.btnIzinRed_Click);
            this.btnIzinRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnIzinRed_MouseDown);
            this.btnIzinRed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnIzinRed_MouseUp);
            // 
            // btnGeriIzinler
            // 
            this.btnGeriIzinler.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGeriIzinler.Font = new System.Drawing.Font("Sitka Display", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriIzinler.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGeriIzinler.Location = new System.Drawing.Point(750, 12);
            this.btnGeriIzinler.Name = "btnGeriIzinler";
            this.btnGeriIzinler.Size = new System.Drawing.Size(89, 41);
            this.btnGeriIzinler.TabIndex = 13;
            this.btnGeriIzinler.Text = "Geri";
            this.btnGeriIzinler.UseVisualStyleBackColor = false;
            this.btnGeriIzinler.Click += new System.EventHandler(this.btnGeriIzinler_Click);
            this.btnGeriIzinler.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGeriIzinler_MouseDown);
            this.btnGeriIzinler.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnGeriIzinler_MouseUp);
            // 
            // IzinIslemleriFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(851, 662);
            this.Controls.Add(this.btnGeriIzinler);
            this.Controls.Add(this.btnIzinRed);
            this.Controls.Add(this.btnIzinKabul);
            this.Controls.Add(this.lblIzinTalepleri);
            this.Controls.Add(this.dgwIzinTalepleri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IzinIslemleriFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İzin İşlemleri";
            this.Load += new System.EventHandler(this.IzinIslemleriFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwIzinTalepleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwIzinTalepleri;
        private System.Windows.Forms.Label lblIzinTalepleri;
        private System.Windows.Forms.Button btnIzinKabul;
        private System.Windows.Forms.Button btnIzinRed;
        private System.Windows.Forms.Button btnGeriIzinler;
    }
}