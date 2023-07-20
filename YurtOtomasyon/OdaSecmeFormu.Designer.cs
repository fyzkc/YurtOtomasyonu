
namespace YurtOtomasyon
{
    partial class OdaSecmeFormu
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
            this.dgwBosOdaSec = new System.Windows.Forms.DataGridView();
            this.btnGeriBosOdaSec = new System.Windows.Forms.Button();
            this.btnBosOdaSec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBosOdaSec)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBosOdaSec
            // 
            this.dgwBosOdaSec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBosOdaSec.Location = new System.Drawing.Point(12, 24);
            this.dgwBosOdaSec.Name = "dgwBosOdaSec";
            this.dgwBosOdaSec.RowHeadersWidth = 56;
            this.dgwBosOdaSec.RowTemplate.Height = 24;
            this.dgwBosOdaSec.Size = new System.Drawing.Size(751, 536);
            this.dgwBosOdaSec.TabIndex = 0;
            // 
            // btnGeriBosOdaSec
            // 
            this.btnGeriBosOdaSec.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGeriBosOdaSec.Font = new System.Drawing.Font("Sitka Display", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriBosOdaSec.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGeriBosOdaSec.Location = new System.Drawing.Point(799, 12);
            this.btnGeriBosOdaSec.Name = "btnGeriBosOdaSec";
            this.btnGeriBosOdaSec.Size = new System.Drawing.Size(89, 41);
            this.btnGeriBosOdaSec.TabIndex = 28;
            this.btnGeriBosOdaSec.Text = "Geri";
            this.btnGeriBosOdaSec.UseVisualStyleBackColor = false;
            this.btnGeriBosOdaSec.Click += new System.EventHandler(this.btnGeriBosOdaSec_Click);
            this.btnGeriBosOdaSec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGeriBosOdaSec_MouseDown);
            this.btnGeriBosOdaSec.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnGeriBosOdaSec_MouseUp);
            // 
            // btnBosOdaSec
            // 
            this.btnBosOdaSec.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBosOdaSec.Font = new System.Drawing.Font("Sitka Display", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBosOdaSec.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnBosOdaSec.Location = new System.Drawing.Point(776, 498);
            this.btnBosOdaSec.Name = "btnBosOdaSec";
            this.btnBosOdaSec.Size = new System.Drawing.Size(119, 62);
            this.btnBosOdaSec.TabIndex = 29;
            this.btnBosOdaSec.Text = "Seç";
            this.btnBosOdaSec.UseVisualStyleBackColor = false;
            this.btnBosOdaSec.Click += new System.EventHandler(this.btnBosOdaSec_Click);
            this.btnBosOdaSec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBosOdaSec_MouseDown);
            this.btnBosOdaSec.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnBosOdaSec_MouseUp);
            // 
            // OdaSecmeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(907, 572);
            this.Controls.Add(this.btnBosOdaSec);
            this.Controls.Add(this.btnGeriBosOdaSec);
            this.Controls.Add(this.dgwBosOdaSec);
            this.Font = new System.Drawing.Font("Sitka Display", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "OdaSecmeFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oda Seç";
            this.Load += new System.EventHandler(this.OdaSecmeFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBosOdaSec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBosOdaSec;
        private System.Windows.Forms.Button btnGeriBosOdaSec;
        private System.Windows.Forms.Button btnBosOdaSec;
    }
}