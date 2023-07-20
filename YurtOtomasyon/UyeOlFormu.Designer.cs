
namespace YurtOtomasyon
{
    partial class UyeOlFormu
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
            this.lblUyeOlSifre = new System.Windows.Forms.Label();
            this.txtUyeOlSifre = new System.Windows.Forms.TextBox();
            this.lblUyeOlTC = new System.Windows.Forms.Label();
            this.txtUyeOlTC = new System.Windows.Forms.TextBox();
            this.btnCikisUyeOl = new System.Windows.Forms.Button();
            this.btnKaydetUyeOl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUyeOlSifre
            // 
            this.lblUyeOlSifre.AutoSize = true;
            this.lblUyeOlSifre.Font = new System.Drawing.Font("Sitka Display", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyeOlSifre.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUyeOlSifre.Location = new System.Drawing.Point(113, 261);
            this.lblUyeOlSifre.Name = "lblUyeOlSifre";
            this.lblUyeOlSifre.Size = new System.Drawing.Size(63, 33);
            this.lblUyeOlSifre.TabIndex = 11;
            this.lblUyeOlSifre.Text = "Şifre";
            // 
            // txtUyeOlSifre
            // 
            this.txtUyeOlSifre.Location = new System.Drawing.Point(265, 272);
            this.txtUyeOlSifre.Name = "txtUyeOlSifre";
            this.txtUyeOlSifre.Size = new System.Drawing.Size(189, 22);
            this.txtUyeOlSifre.TabIndex = 9;
            // 
            // lblUyeOlTC
            // 
            this.lblUyeOlTC.AutoSize = true;
            this.lblUyeOlTC.Font = new System.Drawing.Font("Sitka Display", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyeOlTC.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUyeOlTC.Location = new System.Drawing.Point(113, 203);
            this.lblUyeOlTC.Name = "lblUyeOlTC";
            this.lblUyeOlTC.Size = new System.Drawing.Size(49, 33);
            this.lblUyeOlTC.TabIndex = 13;
            this.lblUyeOlTC.Text = "TC:";
            // 
            // txtUyeOlTC
            // 
            this.txtUyeOlTC.Location = new System.Drawing.Point(265, 212);
            this.txtUyeOlTC.Name = "txtUyeOlTC";
            this.txtUyeOlTC.Size = new System.Drawing.Size(189, 22);
            this.txtUyeOlTC.TabIndex = 12;
            // 
            // btnCikisUyeOl
            // 
            this.btnCikisUyeOl.BackColor = System.Drawing.Color.AliceBlue;
            this.btnCikisUyeOl.Font = new System.Drawing.Font("Sitka Display", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikisUyeOl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCikisUyeOl.Location = new System.Drawing.Point(466, 12);
            this.btnCikisUyeOl.Name = "btnCikisUyeOl";
            this.btnCikisUyeOl.Size = new System.Drawing.Size(89, 41);
            this.btnCikisUyeOl.TabIndex = 14;
            this.btnCikisUyeOl.Text = "Çıkış";
            this.btnCikisUyeOl.UseVisualStyleBackColor = false;
            this.btnCikisUyeOl.Click += new System.EventHandler(this.btnCikisUyeOl_Click);
            this.btnCikisUyeOl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCikisUyeOl_MouseDown);
            this.btnCikisUyeOl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCikisUyeOl_MouseUp);
            // 
            // btnKaydetUyeOl
            // 
            this.btnKaydetUyeOl.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnKaydetUyeOl.Font = new System.Drawing.Font("Sitka Display", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydetUyeOl.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnKaydetUyeOl.Location = new System.Drawing.Point(119, 334);
            this.btnKaydetUyeOl.Name = "btnKaydetUyeOl";
            this.btnKaydetUyeOl.Size = new System.Drawing.Size(110, 55);
            this.btnKaydetUyeOl.TabIndex = 27;
            this.btnKaydetUyeOl.Text = "Kaydet";
            this.btnKaydetUyeOl.UseVisualStyleBackColor = false;
            this.btnKaydetUyeOl.Click += new System.EventHandler(this.btnKaydetUyeOl_Click);
            this.btnKaydetUyeOl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnKaydetUyeOl_MouseDown);
            this.btnKaydetUyeOl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnKaydetUyeOl_MouseUp);
            // 
            // UyeOlFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(567, 592);
            this.Controls.Add(this.btnKaydetUyeOl);
            this.Controls.Add(this.btnCikisUyeOl);
            this.Controls.Add(this.lblUyeOlTC);
            this.Controls.Add(this.txtUyeOlTC);
            this.Controls.Add(this.lblUyeOlSifre);
            this.Controls.Add(this.txtUyeOlSifre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UyeOlFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Ol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUyeOlSifre;
        private System.Windows.Forms.TextBox txtUyeOlSifre;
        private System.Windows.Forms.Label lblUyeOlTC;
        private System.Windows.Forms.TextBox txtUyeOlTC;
        private System.Windows.Forms.Button btnCikisUyeOl;
        private System.Windows.Forms.Button btnKaydetUyeOl;
    }
}