
namespace YurtOtomasyon
{
    partial class KayitSilmeFormu
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
            this.dgwKayitSil = new System.Windows.Forms.DataGridView();
            this.btnGeriKayitSil = new System.Windows.Forms.Button();
            this.btnKayitSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKayitSil)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwKayitSil
            // 
            this.dgwKayitSil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKayitSil.Location = new System.Drawing.Point(12, 12);
            this.dgwKayitSil.Name = "dgwKayitSil";
            this.dgwKayitSil.RowHeadersWidth = 56;
            this.dgwKayitSil.RowTemplate.Height = 24;
            this.dgwKayitSil.Size = new System.Drawing.Size(676, 674);
            this.dgwKayitSil.TabIndex = 0;
            // 
            // btnGeriKayitSil
            // 
            this.btnGeriKayitSil.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGeriKayitSil.Font = new System.Drawing.Font("Sitka Display", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriKayitSil.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGeriKayitSil.Location = new System.Drawing.Point(740, 12);
            this.btnGeriKayitSil.Name = "btnGeriKayitSil";
            this.btnGeriKayitSil.Size = new System.Drawing.Size(89, 41);
            this.btnGeriKayitSil.TabIndex = 28;
            this.btnGeriKayitSil.Text = "Geri";
            this.btnGeriKayitSil.UseVisualStyleBackColor = false;
            this.btnGeriKayitSil.Click += new System.EventHandler(this.btnGeriKayitSil_Click);
            this.btnGeriKayitSil.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGeriKayitSil_MouseDown);
            this.btnGeriKayitSil.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnGeriKayitSil_MouseUp);
            // 
            // btnKayitSil
            // 
            this.btnKayitSil.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnKayitSil.Font = new System.Drawing.Font("Sitka Display", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitSil.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnKayitSil.Location = new System.Drawing.Point(694, 610);
            this.btnKayitSil.Name = "btnKayitSil";
            this.btnKayitSil.Size = new System.Drawing.Size(135, 76);
            this.btnKayitSil.TabIndex = 29;
            this.btnKayitSil.Text = "Sil";
            this.btnKayitSil.UseVisualStyleBackColor = false;
            this.btnKayitSil.Click += new System.EventHandler(this.btnKayitSil_Click);
            this.btnKayitSil.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnKayitSil_MouseDown);
            this.btnKayitSil.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnKayitSil_MouseUp);
            // 
            // KayitSilmeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(841, 698);
            this.Controls.Add(this.btnKayitSil);
            this.Controls.Add(this.btnGeriKayitSil);
            this.Controls.Add(this.dgwKayitSil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "KayitSilmeFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Silme";
            this.Load += new System.EventHandler(this.KayitSilmeFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKayitSil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwKayitSil;
        private System.Windows.Forms.Button btnGeriKayitSil;
        private System.Windows.Forms.Button btnKayitSil;
    }
}