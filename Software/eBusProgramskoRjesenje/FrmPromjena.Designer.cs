namespace eBusProgramskoRjesenje
{
    partial class FrmPromjena
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
            this.cboVrstaVozilaPromjena = new System.Windows.Forms.ComboBox();
            this.txtModelPromjena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPormjeniPodatke = new System.Windows.Forms.Button();
            this.txtDetaljneInformacijePromjena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamjenaVozilaPromjena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTablicaVozilaPromjena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboVrstaVozilaPromjena
            // 
            this.cboVrstaVozilaPromjena.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVrstaVozilaPromjena.FormattingEnabled = true;
            this.cboVrstaVozilaPromjena.Location = new System.Drawing.Point(134, 181);
            this.cboVrstaVozilaPromjena.Name = "cboVrstaVozilaPromjena";
            this.cboVrstaVozilaPromjena.Size = new System.Drawing.Size(179, 24);
            this.cboVrstaVozilaPromjena.TabIndex = 24;
            // 
            // txtModelPromjena
            // 
            this.txtModelPromjena.Location = new System.Drawing.Point(134, 137);
            this.txtModelPromjena.Name = "txtModelPromjena";
            this.txtModelPromjena.Size = new System.Drawing.Size(131, 22);
            this.txtModelPromjena.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Model vozila:";
            // 
            // btnPormjeniPodatke
            // 
            this.btnPormjeniPodatke.Location = new System.Drawing.Point(505, 297);
            this.btnPormjeniPodatke.Name = "btnPormjeniPodatke";
            this.btnPormjeniPodatke.Size = new System.Drawing.Size(165, 36);
            this.btnPormjeniPodatke.TabIndex = 21;
            this.btnPormjeniPodatke.Text = "Promjeni podatke";
            this.btnPormjeniPodatke.UseVisualStyleBackColor = true;
            this.btnPormjeniPodatke.Click += new System.EventHandler(this.btnPormjeniPodatke_Click);
            // 
            // txtDetaljneInformacijePromjena
            // 
            this.txtDetaljneInformacijePromjena.Location = new System.Drawing.Point(384, 137);
            this.txtDetaljneInformacijePromjena.Multiline = true;
            this.txtDetaljneInformacijePromjena.Name = "txtDetaljneInformacijePromjena";
            this.txtDetaljneInformacijePromjena.Size = new System.Drawing.Size(286, 154);
            this.txtDetaljneInformacijePromjena.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Detaljne informacije:";
            // 
            // txtNamjenaVozilaPromjena
            // 
            this.txtNamjenaVozilaPromjena.Location = new System.Drawing.Point(134, 269);
            this.txtNamjenaVozilaPromjena.Name = "txtNamjenaVozilaPromjena";
            this.txtNamjenaVozilaPromjena.Size = new System.Drawing.Size(179, 22);
            this.txtNamjenaVozilaPromjena.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Namjena vozila: ";
            // 
            // txtTablicaVozilaPromjena
            // 
            this.txtTablicaVozilaPromjena.Location = new System.Drawing.Point(134, 225);
            this.txtTablicaVozilaPromjena.Name = "txtTablicaVozilaPromjena";
            this.txtTablicaVozilaPromjena.Size = new System.Drawing.Size(131, 22);
            this.txtTablicaVozilaPromjena.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tablica vozila:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Vrsta vozila: ";
            // 
            // FrmPromjena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboVrstaVozilaPromjena);
            this.Controls.Add(this.txtModelPromjena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPormjeniPodatke);
            this.Controls.Add(this.txtDetaljneInformacijePromjena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNamjenaVozilaPromjena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTablicaVozilaPromjena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmPromjena";
            this.Text = "FrmPromjena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboVrstaVozilaPromjena;
        private System.Windows.Forms.TextBox txtModelPromjena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPormjeniPodatke;
        private System.Windows.Forms.TextBox txtDetaljneInformacijePromjena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamjenaVozilaPromjena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTablicaVozilaPromjena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}