using eBusProgramskoRjesenje.Models;
using eBusProgramskoRjesenje.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBusProgramskoRjesenje
{
    public partial class FrmDodajVozilo : Form
    {
        public FrmDodajVozilo()
        {
            InitializeComponent();
        }

        private void LoadVrsteVozila()
        {
            List<Vrsta_vozila> vrsteVozila = RepozitorijVoznogParka.GetVrstaVozila();
            cboVrstaVozila.DataSource = vrsteVozila;
            cboVrstaVozila.DisplayMember = "NazivVrsteVozila";
            cboVrstaVozila.ValueMember = "IdVrsteVozila";
        }

        private void btnDodajNovoVozilo_Click(object sender, EventArgs e)
        {

            string modelVozila = txtModelVozila.Text;
            int idVrstaVozila = (int)cboVrstaVozila.SelectedValue;
            string tablicaVozila = txtTablicaVozila.Text;
            string namjenaVozila = txtNamjenaVozila.Text;
            string detaljneInformacije = txtDetaljneInformacije.Text;
            try 
            {
                RepozitorijVoznogParka.DodajNovoVozilo(modelVozila, idVrstaVozila, tablicaVozila, namjenaVozila, detaljneInformacije);
                MessageBox.Show("Vozilo je uspiješno dodano u bazu podataka.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            } catch
            {
                MessageBox.Show("Nije uspjelo.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmDodajVozilo_Load(object sender, EventArgs e)
        {
            LoadVrsteVozila();
        }
    }
}
