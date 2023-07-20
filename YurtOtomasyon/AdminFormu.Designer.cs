
namespace YurtOtomasyon
{
    partial class AdminFormu
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
            this.components = new System.ComponentModel.Container();
            this.btnOgrenciİsleri = new System.Windows.Forms.Button();
            this.btnOdalar = new System.Windows.Forms.Button();
            this.btnIzinIslemleri = new System.Windows.Forms.Button();
            this.lblSaat = new System.Windows.Forms.Label();
            this.timerSaat = new System.Windows.Forms.Timer(this.components);
            this.calendarAdmin = new System.Windows.Forms.MonthCalendar();
            this.dgwIzinler = new System.Windows.Forms.DataGridView();
            this.dgwBorclar = new System.Windows.Forms.DataGridView();
            this.lblIzinler = new System.Windows.Forms.Label();
            this.lblBorclar = new System.Windows.Forms.Label();
            this.btnCikisAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIzinler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBorclar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOgrenciİsleri
            // 
            this.btnOgrenciİsleri.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOgrenciİsleri.Font = new System.Drawing.Font("Sitka Display", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciİsleri.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnOgrenciİsleri.Location = new System.Drawing.Point(0, -1);
            this.btnOgrenciİsleri.Name = "btnOgrenciİsleri";
            this.btnOgrenciİsleri.Size = new System.Drawing.Size(369, 219);
            this.btnOgrenciİsleri.TabIndex = 0;
            this.btnOgrenciİsleri.Text = "Öğrenci";
            this.btnOgrenciİsleri.UseVisualStyleBackColor = false;
            this.btnOgrenciİsleri.Click += new System.EventHandler(this.btnOgrenciİsleri_Click);
            this.btnOgrenciİsleri.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnOgrenciİsleri_MouseDown);
            this.btnOgrenciİsleri.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnOgrenciİsleri_MouseUp);
            // 
            // btnOdalar
            // 
            this.btnOdalar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOdalar.Font = new System.Drawing.Font("Sitka Display", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdalar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnOdalar.Location = new System.Drawing.Point(0, 214);
            this.btnOdalar.Name = "btnOdalar";
            this.btnOdalar.Size = new System.Drawing.Size(369, 217);
            this.btnOdalar.TabIndex = 1;
            this.btnOdalar.Text = "Odalar";
            this.btnOdalar.UseVisualStyleBackColor = false;
            this.btnOdalar.Click += new System.EventHandler(this.btnOdalar_Click);
            this.btnOdalar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnOdalar_MouseDown);
            this.btnOdalar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnOdalar_MouseUp);
            // 
            // btnIzinIslemleri
            // 
            this.btnIzinIslemleri.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnIzinIslemleri.Font = new System.Drawing.Font("Sitka Display", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIzinIslemleri.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnIzinIslemleri.Location = new System.Drawing.Point(0, 429);
            this.btnIzinIslemleri.Name = "btnIzinIslemleri";
            this.btnIzinIslemleri.Size = new System.Drawing.Size(369, 217);
            this.btnIzinIslemleri.TabIndex = 2;
            this.btnIzinIslemleri.Text = "İzin İşlemleri";
            this.btnIzinIslemleri.UseVisualStyleBackColor = false;
            this.btnIzinIslemleri.Click += new System.EventHandler(this.btnIzinIslemleri_Click);
            this.btnIzinIslemleri.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnIzinIslemleri_MouseDown);
            this.btnIzinIslemleri.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnIzinIslemleri_MouseUp);
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Times New Roman", 28.24615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.Location = new System.Drawing.Point(961, 441);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(0, 58);
            this.lblSaat.TabIndex = 3;
            // 
            // timerSaat
            // 
            this.timerSaat.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // calendarAdmin
            // 
            this.calendarAdmin.Location = new System.Drawing.Point(889, 480);
            this.calendarAdmin.Name = "calendarAdmin";
            this.calendarAdmin.TabIndex = 4;
            // 
            // dgwIzinler
            // 
            this.dgwIzinler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIzinler.Location = new System.Drawing.Point(407, 59);
            this.dgwIzinler.Name = "dgwIzinler";
            this.dgwIzinler.RowHeadersWidth = 56;
            this.dgwIzinler.RowTemplate.Height = 24;
            this.dgwIzinler.Size = new System.Drawing.Size(326, 372);
            this.dgwIzinler.TabIndex = 5;
            // 
            // dgwBorclar
            // 
            this.dgwBorclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBorclar.Location = new System.Drawing.Point(789, 59);
            this.dgwBorclar.Name = "dgwBorclar";
            this.dgwBorclar.RowHeadersWidth = 56;
            this.dgwBorclar.RowTemplate.Height = 24;
            this.dgwBorclar.Size = new System.Drawing.Size(326, 372);
            this.dgwBorclar.TabIndex = 6;
            // 
            // lblIzinler
            // 
            this.lblIzinler.AutoSize = true;
            this.lblIzinler.Font = new System.Drawing.Font("Sitka Display", 18.27692F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIzinler.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblIzinler.Location = new System.Drawing.Point(399, 8);
            this.lblIzinler.Name = "lblIzinler";
            this.lblIzinler.Size = new System.Drawing.Size(112, 48);
            this.lblIzinler.TabIndex = 7;
            this.lblIzinler.Text = "İzinler";
            // 
            // lblBorclar
            // 
            this.lblBorclar.AutoSize = true;
            this.lblBorclar.Font = new System.Drawing.Font("Sitka Display", 18.27692F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBorclar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBorclar.Location = new System.Drawing.Point(781, 8);
            this.lblBorclar.Name = "lblBorclar";
            this.lblBorclar.Size = new System.Drawing.Size(124, 48);
            this.lblBorclar.TabIndex = 8;
            this.lblBorclar.Text = "Borçlar";
            // 
            // btnCikisAdmin
            // 
            this.btnCikisAdmin.BackColor = System.Drawing.Color.AliceBlue;
            this.btnCikisAdmin.Font = new System.Drawing.Font("Sitka Display", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikisAdmin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCikisAdmin.Location = new System.Drawing.Point(1025, 8);
            this.btnCikisAdmin.Name = "btnCikisAdmin";
            this.btnCikisAdmin.Size = new System.Drawing.Size(89, 41);
            this.btnCikisAdmin.TabIndex = 9;
            this.btnCikisAdmin.Text = "Çıkış";
            this.btnCikisAdmin.UseVisualStyleBackColor = false;
            this.btnCikisAdmin.Click += new System.EventHandler(this.btnCikisAdmin_Click);
            this.btnCikisAdmin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCikisAdmin_MouseDown);
            this.btnCikisAdmin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCikisAdmin_MouseUp);
            // 
            // AdminFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1126, 645);
            this.Controls.Add(this.btnCikisAdmin);
            this.Controls.Add(this.lblBorclar);
            this.Controls.Add(this.lblIzinler);
            this.Controls.Add(this.dgwBorclar);
            this.Controls.Add(this.dgwIzinler);
            this.Controls.Add(this.calendarAdmin);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.btnIzinIslemleri);
            this.Controls.Add(this.btnOdalar);
            this.Controls.Add(this.btnOgrenciİsleri);
            this.Font = new System.Drawing.Font("Sitka Display", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "AdminFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetim";
            this.Load += new System.EventHandler(this.AdminFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwIzinler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBorclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenciİsleri;
        private System.Windows.Forms.Button btnOdalar;
        private System.Windows.Forms.Button btnIzinIslemleri;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Timer timerSaat;
        private System.Windows.Forms.MonthCalendar calendarAdmin;
        private System.Windows.Forms.DataGridView dgwIzinler;
        private System.Windows.Forms.DataGridView dgwBorclar;
        private System.Windows.Forms.Label lblIzinler;
        private System.Windows.Forms.Label lblBorclar;
        private System.Windows.Forms.Button btnCikisAdmin;
    }
}