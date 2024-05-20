namespace eBusProgramskoRjesenje
{
    partial class FrmDodajVozilo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTablicaVozila = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamjenaVozila = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDetaljneInformacije = new System.Windows.Forms.TextBox();
            this.btnDodajNovoVozilo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModelVozila = new System.Windows.Forms.TextBox();
            this.cboVrstaVozila = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vrsta vozila: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tablica vozila:";
            // 
            // txtTablicaVozila
            // 
            this.txtTablicaVozila.Location = new System.Drawing.Point(114, 191);
            this.txtTablicaVozila.Name = "txtTablicaVozila";
            this.txtTablicaVozila.Size = new System.Drawing.Size(131, 22);
            this.txtTablicaVozila.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Namjena vozila: ";
            // 
            // txtNamjenaVozila
            // 
            this.txtNamjenaVozila.Location = new System.Drawing.Point(114, 235);
            this.txtNamjenaVozila.Name = "txtNamjenaVozila";
            this.txtNamjenaVozila.Size = new System.Drawing.Size(179, 22);
            this.txtNamjenaVozila.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Detaljne informacije:";
            // 
            // txtDetaljneInformacije
            // 
            this.txtDetaljneInformacije.Location = new System.Drawing.Point(364, 103);
            this.txtDetaljneInformacije.Multiline = true;
            this.txtDetaljneInformacije.Name = "txtDetaljneInformacije";
            this.txtDetaljneInformacije.Size = new System.Drawing.Size(286, 154);
            this.txtDetaljneInformacije.TabIndex = 9;
            // 
            // btnDodajNovoVozilo
            // 
            this.btnDodajNovoVozilo.Location = new System.Drawing.Point(485, 263);
            this.btnDodajNovoVozilo.Name = "btnDodajNovoVozilo";
            this.btnDodajNovoVozilo.Size = new System.Drawing.Size(165, 36);
            this.btnDodajNovoVozilo.TabIndex = 10;
            this.btnDodajNovoVozilo.Text = "Dodaj novo vozilo";
            this.btnDodajNovoVozilo.UseVisualStyleBackColor = true;
            this.btnDodajNovoVozilo.Click += new System.EventHandler(this.btnDodajNovoVozilo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Model vozila:";
            // 
            // txtModelVozila
            // 
            this.txtModelVozila.Location = new System.Drawing.Point(114, 103);
            this.txtModelVozila.Name = "txtModelVozila";
            this.txtModelVozila.Size = new System.Drawing.Size(131, 22);
            this.txtModelVozila.TabIndex = 12;
            // 
            // cboVrstaVozila
            // 
            this.cboVrstaVozila.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVrstaVozila.FormattingEnabled = true;
            this.cboVrstaVozila.Location = new System.Drawing.Point(114, 147);
            this.cboVrstaVozila.Name = "cboVrstaVozila";
            this.cboVrstaVozila.Size = new System.Drawing.Size(179, 24);
            this.cboVrstaVozila.TabIndex = 13;
            // 
            // FrmDodajVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 401);
            this.Controls.Add(this.cboVrstaVozila);
            this.Controls.Add(this.txtModelVozila);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajNovoVozilo);
            this.Controls.Add(this.txtDetaljneInformacije);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNamjenaVozila);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTablicaVozila);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDodajVozilo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDodajVozilo";
            this.Load += new System.EventHandler(this.FrmDodajVozilo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTablicaVozila;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamjenaVozila;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDetaljneInformacije;
        private System.Windows.Forms.Button btnDodajNovoVozilo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModelVozila;
        private System.Windows.Forms.ComboBox cboVrstaVozila;
    }
}