
namespace YurtOtomasyon
{
    partial class ButunKayitlarGoruntulemeFormu
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
            this.dgwButunKayitlar = new System.Windows.Forms.DataGridView();
            this.btnGeriButunKayitlar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwButunKayitlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwButunKayitlar
            // 
            this.dgwButunKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwButunKayitlar.Location = new System.Drawing.Point(12, 23);
            this.dgwButunKayitlar.Name = "dgwButunKayitlar";
            this.dgwButunKayitlar.RowHeadersWidth = 56;
            this.dgwButunKayitlar.RowTemplate.Height = 24;
            this.dgwButunKayitlar.Size = new System.Drawing.Size(749, 632);
            this.dgwButunKayitlar.TabIndex = 0;
            // 
            // btnGeriButunKayitlar
            // 
            this.btnGeriButunKayitlar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGeriButunKayitlar.Font = new System.Drawing.Font("Sitka Display", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriButunKayitlar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGeriButunKayitlar.Location = new System.Drawing.Point(791, 12);
            this.btnGeriButunKayitlar.Name = "btnGeriButunKayitlar";
            this.btnGeriButunKayitlar.Size = new System.Drawing.Size(89, 41);
            this.btnGeriButunKayitlar.TabIndex = 13;
            this.btnGeriButunKayitlar.Text = "Geri";
            this.btnGeriButunKayitlar.UseVisualStyleBackColor = false;
            this.btnGeriButunKayitlar.Click += new System.EventHandler(this.btnGeriButunKayitlar_Click);
            this.btnGeriButunKayitlar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGeriButunKayitlar_MouseDown);
            this.btnGeriButunKayitlar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnGeriButunKayitlar_MouseUp);
            // 
            // ButunKayitlarGoruntulemeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(892, 685);
            this.Controls.Add(this.btnGeriButunKayitlar);
            this.Controls.Add(this.dgwButunKayitlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ButunKayitlarGoruntulemeFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bütün Kayıtlar";
            this.Load += new System.EventHandler(this.ButunKayitlarGoruntulemeFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwButunKayitlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwButunKayitlar;
        private System.Windows.Forms.Button btnGeriButunKayitlar;
    }
}