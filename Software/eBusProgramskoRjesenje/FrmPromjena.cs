﻿using eBusProgramskoRjesenje.Models;
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

        //Prikaz forme i naziv
        public FrmPromjena(Vozilo vozilo)
        {
            InitializeComponent();
            this.vozilo = vozilo;
            LoadVrsteVozila();
            LoadVoziloData();
            this.Text = "Promjena podataka za vozilo: " + vozilo.ModelVozila; 
        }

        //Lista za prikaz vrste vozila kod promjene
        private void LoadVrsteVozila()
        {
            List<Vrsta_vozila> vrsteVozila = RepozitorijVrsteVozila.GetVrstaVozila();
            foreach (Vrsta_vozila vv in vrsteVozila)
            {
                cboVrstaVozilaPromjena.Items.Add(vv.NazivVrsteVozila.Trim());

            }
            cboVrstaVozilaPromjena.DisplayMember = "NazivVrsteVozila";
            cboVrstaVozilaPromjena.ValueMember = "IdVrsteVozila";
        }

        //Ucitavanje dohvacenih podataka
        private void LoadVoziloData()
        { 
            txtModelPromjena.Text = vozilo.ModelVozila.Trim();
            cboVrstaVozilaPromjena.SelectedItem = RepozitorijVrsteVozila.GetVrstaVozilaById(int.Parse(vozilo.IdVrsteVozila)).NazivVrsteVozila.Trim();
            txtTablicaVozilaPromjena.Text = vozilo.TablicaVozila.Trim();
            txtNamjenaVozilaPromjena.Text = vozilo.NamjenaVozila.Trim();
            txtDetaljneInformacijePromjena.Text = vozilo.DetaljneInformacije.Trim();
        }

        //Gumb za promjenu podataka
        private void btnPormjeniPodatke_Click(object sender, EventArgs e)
        {
            string ModelVozila = txtModelPromjena.Text;
            int IdVrsteVozila = RepozitorijVrsteVozila.GetVrstaVozilaByName((string)cboVrstaVozilaPromjena.SelectedItem).IdVrsteVozila;
            string TablicaVozila = txtTablicaVozilaPromjena.Text;
            string NamjenaVozila = txtNamjenaVozilaPromjena.Text;
            string DetaljneInformacije = txtDetaljneInformacijePromjena.Text;

            RepozitorijVoznogParka.UpdateVozilo(vozilo.IdVozila, ModelVozila, IdVrsteVozila, TablicaVozila, NamjenaVozila, DetaljneInformacije);
            MessageBox.Show("Podaci su uspješno ažurirani.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void FrmPromjena_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }
    }
}
