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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVozniPark = new System.Windows.Forms.DataGridView();
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.btnBrisanje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozniPark)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVozniPark
            // 
            this.dgvVozniPark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVozniPark.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVozniPark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVozniPark.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVozniPark.Location = new System.Drawing.Point(25, 27);
            this.dgvVozniPark.MultiSelect = false;
            this.dgvVozniPark.Name = "dgvVozniPark";
            this.dgvVozniPark.ReadOnly = true;
            this.dgvVozniPark.RowHeadersWidth = 51;
            this.dgvVozniPark.RowTemplate.Height = 24;
            this.dgvVozniPark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvVozniPark.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVozniPark.Size = new System.Drawing.Size(1053, 343);
            this.dgvVozniPark.TabIndex = 0;
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.Location = new System.Drawing.Point(930, 389);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(148, 61);
            this.btnDodajVozilo.TabIndex = 1;
            this.btnDodajVozilo.Text = "Dodaj vozilo";
            this.btnDodajVozilo.UseVisualStyleBackColor = true;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(150, 386);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(196, 22);
            this.txtPretraga.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Unos za pretragu:";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(352, 386);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 4;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.Location = new System.Drawing.Point(776, 389);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(148, 61);
            this.btnBrisanje.TabIndex = 5;
            this.btnBrisanje.Text = "Obriši vozilo";
            this.btnBrisanje.UseVisualStyleBackColor = true;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            // 
            // FrmVozniPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 507);
            this.Controls.Add(this.btnBrisanje);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnDodajVozilo);
            this.Controls.Add(this.dgvVozniPark);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmVozniPark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVozniPark";
            this.Load += new System.EventHandler(this.FrmVozniPark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozniPark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVozniPark;
        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Button btnBrisanje;
    }
}