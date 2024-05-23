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
    public partial class FrmVozniPark : Form
    {

        private BindingList<Vozilo> vozila;

        public FrmVozniPark()
        {
            InitializeComponent();
        }

        private void FrmVozniPark_Load(object sender, EventArgs e)
        {
            ShowVozila();
            dgvVozniPark.ClearSelection();
        }

        //Prikaz popisa vozila iz baze podataka u DataGridView
        private void ShowVozila()
        {
            List<Vozilo> vozilaList = RepozitorijVozila.GetVozila();
            vozila = new BindingList<Vozilo>(vozilaList);
            dgvVozniPark.DataSource = vozila;

        }

        //Gumb za dodavanje novog vozila
        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            FrmDodajVozilo frmDodajVozilo = new FrmDodajVozilo();   
            frmDodajVozilo.ShowDialog();
            ShowVozila();
        }

        //Gumb za brisanje novog vozila
        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            if (dgvVozniPark.SelectedRows.Count > 0)
            {
                int odabranIndeks = dgvVozniPark.SelectedRows[0].Index;
                if (odabranIndeks >= 0 && odabranIndeks < vozila.Count)
                {
                    int odabranoVoziloId = (int)dgvVozniPark.Rows[odabranIndeks].Cells["IdVozila"].Value;

                    var potvrda = MessageBox.Show("Jeste li sigurni da želite obrisati ovo vozilo?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (potvrda == DialogResult.Yes)
                    {
                        bool uspjesnoBrisanje = RepozitorijVoznogParka.ObrisiVozilo(odabranoVoziloId);

                        if (uspjesnoBrisanje)
                        {
                            vozila.RemoveAt(odabranIndeks);
                            MessageBox.Show("Vozilo je uspješno obrisano.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Došlo je do greške prilikom brisanja vozila.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Molimo odaberite željeno vozilo za brisanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else {
                MessageBox.Show("Molimo odaberite željeno vozilo za brisanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }   

        private void btnPromjeni_Click(object sender, EventArgs e)
        {
            if (dgvVozniPark.SelectedRows.Count > 0)
            {
                int odabranIndeks = dgvVozniPark.SelectedRows[0].Index;
                if (odabranIndeks >= 0 && odabranIndeks < dgvVozniPark.Rows.Count)
                {
                    int odabranoVoziloId = (int)dgvVozniPark.Rows[odabranIndeks].Cells["IdVozila"].Value;
                    Vozilo odabranoVozilo = RepozitorijVozila.GetVozilo(odabranoVoziloId);

                    if (odabranoVozilo != null)
                    {
                        FrmPromjena frmPromjena = new FrmPromjena(odabranoVozilo);
                        frmPromjena.ShowDialog();
                        ShowVozila();
                    }
                }
            }
            else 
            {
                MessageBox.Show("Molimo odaberite željeno vozilo za promjenu.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPretraga.Text))
            {
                MessageBox.Show("Molimo unesite parametre za pretragu.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kriterij = txtPretraga.Text;
            List<Vozilo> pretrazenaVozila = RepozitorijVozila.GetPretrazenaVozila(kriterij);

            if (pretrazenaVozila.Count == 0)
            {
                MessageBox.Show("Nepostojeći podaci u bazi.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                OsvjeziPrikaz(pretrazenaVozila);
                dgvVozniPark.ClearSelection();
            }
        }

        private void OsvjeziPrikaz(List<Vozilo> vozila)
        { 
            dgvVozniPark.DataSource = vozila;
            dgvVozniPark.Refresh();
        }

        private void btnResetiraj_Click(object sender, EventArgs e)
        {
            txtPretraga.Text = string.Empty;
            ShowVozila();
            dgvVozniPark.ClearSelection();
        }
    }
}

