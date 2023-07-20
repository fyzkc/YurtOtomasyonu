
namespace YurtOtomasyon
{
    partial class OgrenciGirisForm
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
            this.btnOgrenciIzin = new System.Windows.Forms.Button();
            this.btnCikisOgrenci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOgrenciIzin
            // 
            this.btnOgrenciIzin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOgrenciIzin.Font = new System.Drawing.Font("Sitka Display", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciIzin.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnOgrenciIzin.Location = new System.Drawing.Point(174, 242);
            this.btnOgrenciIzin.Name = "btnOgrenciIzin";
            this.btnOgrenciIzin.Size = new System.Drawing.Size(273, 103);
            this.btnOgrenciIzin.TabIndex = 0;
            this.btnOgrenciIzin.Text = "İzin İşlemleri";
            this.btnOgrenciIzin.UseVisualStyleBackColor = false;
            this.btnOgrenciIzin.Click += new System.EventHandler(this.btnOgrenciIzin_Click);
            this.btnOgrenciIzin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnOgrenciIzin_MouseDown);
            this.btnOgrenciIzin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnOgrenciIzin_MouseUp);
            // 
            // btnCikisOgrenci
            // 
            this.btnCikisOgrenci.BackColor = System.Drawing.Color.AliceBlue;
            this.btnCikisOgrenci.Font = new System.Drawing.Font("Sitka Display", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikisOgrenci.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCikisOgrenci.Location = new System.Drawing.Point(520, 12);
            this.btnCikisOgrenci.Name = "btnCikisOgrenci";
            this.btnCikisOgrenci.Size = new System.Drawing.Size(89, 41);
            this.btnCikisOgrenci.TabIndex = 10;
            this.btnCikisOgrenci.Text = "Çıkış";
            this.btnCikisOgrenci.UseVisualStyleBackColor = false;
            this.btnCikisOgrenci.Click += new System.EventHandler(this.btnCikisOgrenci_Click);
            this.btnCikisOgrenci.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCikisOgrenci_MouseDown);
            this.btnCikisOgrenci.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCikisOgrenci_MouseUp);
            // 
            // OgrenciGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(621, 586);
            this.Controls.Add(this.btnCikisOgrenci);
            this.Controls.Add(this.btnOgrenciIzin);
            this.Font = new System.Drawing.Font("Sitka Display", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "OgrenciGirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenciIzin;
        private System.Windows.Forms.Button btnCikisOgrenci;
    }
}