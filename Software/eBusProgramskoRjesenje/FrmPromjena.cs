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
    public partial class FrmPromjena : Form
    {
        private Vozilo vozilo;
        public FrmPromjena(Vozilo vozilo)
        {
            InitializeComponent();
            this.vozilo = vozilo;
            LoadVrsteVozila();
            LoadVoziloData();
        }

        private void LoadVrsteVozila()
        {
            List<Vrsta_vozila> vrsteVozila = RepozitorijVrsteVozila.GetVrstaVozila();
            foreach (Vrsta_vozila vv in vrsteVozila)
            {
                cboVrstaVozilaPromjena.Items.Add(vv.NazivVrsteVozila.Trim());

            }
            //cboVrstaVozilaPromjena.DataSource = vrsteVozila;
            cboVrstaVozilaPromjena.DisplayMember = "NazivVrsteVozila";
            cboVrstaVozilaPromjena.ValueMember = "IdVrsteVozila";
            
        }

        private void LoadVoziloData()
        { 
            txtModelPromjena.Text = vozilo.ModelVozila;
            cboVrstaVozilaPromjena.SelectedItem = RepozitorijVrsteVozila.GetVrstaVozilaById(int.Parse(vozilo.IdVrsteVozila)).NazivVrsteVozila.Trim();
            txtTablicaVozilaPromjena.Text = vozilo.TablicaVozila;
            txtNamjenaVozilaPromjena.Text = vozilo.NamjenaVozila;
            txtDetaljneInformacijePromjena.Text = vozilo.DetaljneInformacije;
        }

        private void btnPormjeniPodatke_Click(object sender, EventArgs e)
        {
            string ModelVozila = txtModelPromjena.Text;
            int IdVrsteVozila = RepozitorijVrsteVozila.GetVrstaVozilaByName((string)cboVrstaVozilaPromjena.SelectedItem).IdVrsteVozila;
            string TablicaVozila = txtTablicaVozilaPromjena.Text;
            string NamjenaVozila = txtNamjenaVozilaPromjena.Text;
            string DetaljneInformacije = txtDetaljneInformacijePromjena.Text;

            //RepozitorijVoznogParka.GetVrstaVozilaById(int.Parse(vozilo.NazivVrsteVozila))

            //string sql = $"UPDATE vozilo SET model_vozila = '{ModelVozila}', Id_vrste_vozila = {IdVrsteVozila}, tablica_vozila = '{TablicaVozila}', namjena_vozila = '{NamjenaVozila}, detaljne_informacije = '{DetaljneInformacijeVozila}' WHERE Id_vozila = {IdVozila}";/
            //int IdVozila, string ModelVozila, int IdVrsteVozila, string TablicaVozila, string NamjenaVozila, string DetaljneInformacijeVozila
            RepozitorijVoznogParka.UpdateVozilo(vozilo.IdVozila, ModelVozila, IdVrsteVozila, TablicaVozila, NamjenaVozila, DetaljneInformacije);
            MessageBox.Show("Podaci su uspješno ažurirani.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
