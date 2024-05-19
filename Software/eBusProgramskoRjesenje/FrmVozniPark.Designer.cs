namespace eBusProgramskoRjesenje
{
    partial class FrmVozniPark
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
            this.dgvVozniPark = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozniPark)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVozniPark
            // 
            this.dgvVozniPark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVozniPark.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVozniPark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozniPark.Location = new System.Drawing.Point(25, 27);
            this.dgvVozniPark.Name = "dgvVozniPark";
            this.dgvVozniPark.RowHeadersWidth = 51;
            this.dgvVozniPark.RowTemplate.Height = 24;
            this.dgvVozniPark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvVozniPark.Size = new System.Drawing.Size(1059, 343);
            this.dgvVozniPark.TabIndex = 0;
            // 
            // FrmVozniPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 504);
            this.Controls.Add(this.dgvVozniPark);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmVozniPark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVozniPark";
            this.Load += new System.EventHandler(this.FrmVozniPark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozniPark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVozniPark;
    }
}