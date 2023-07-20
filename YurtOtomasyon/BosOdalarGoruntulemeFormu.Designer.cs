
namespace YurtOtomasyon
{
    partial class BosOdalarGoruntulemeFormu
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
            this.dgwBosOdalar = new System.Windows.Forms.DataGridView();
            this.btnGeriBosOdalar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBosOdalar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBosOdalar
            // 
            this.dgwBosOdalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBosOdalar.Location = new System.Drawing.Point(12, 23);
            this.dgwBosOdalar.Name = "dgwBosOdalar";
            this.dgwBosOdalar.RowHeadersWidth = 56;
            this.dgwBosOdalar.RowTemplate.Height = 24;
            this.dgwBosOdalar.Size = new System.Drawing.Size(749, 632);
            this.dgwBosOdalar.TabIndex = 1;
            // 
            // btnGeriBosOdalar
            // 
            this.btnGeriBosOdalar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGeriBosOdalar.Font = new System.Drawing.Font("Sitka Display", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriBosOdalar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGeriBosOdalar.Location = new System.Drawing.Point(791, 12);
            this.btnGeriBosOdalar.Name = "btnGeriBosOdalar";
            this.btnGeriBosOdalar.Size = new System.Drawing.Size(89, 41);
            this.btnGeriBosOdalar.TabIndex = 14;
            this.btnGeriBosOdalar.Text = "Geri";
            this.btnGeriBosOdalar.UseVisualStyleBackColor = false;
            this.btnGeriBosOdalar.Click += new System.EventHandler(this.btnGeriBosOdalar_Click);
            this.btnGeriBosOdalar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGeriBosOdalar_MouseDown);
            this.btnGeriBosOdalar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnGeriBosOdalar_MouseUp);
            // 
            // BosOdalarGoruntulemeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(892, 685);
            this.Controls.Add(this.btnGeriBosOdalar);
            this.Controls.Add(this.dgwBosOdalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BosOdalarGoruntulemeFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boş Odalar";
            this.Load += new System.EventHandler(this.BosOdalarGoruntulemeFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBosOdalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBosOdalar;
        private System.Windows.Forms.Button btnGeriBosOdalar;
    }
}