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

        private void ShowVozila()
        {
            List<Vozilo> vozilaList = RepozitorijVoznogParka.GetVozila();
            vozila = new BindingList<Vozilo>(vozilaList);
            dgvVozniPark.DataSource = vozila;

        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            FrmDodajVozilo frmDodajVozilo = new FrmDodajVozilo();   
            frmDodajVozilo.ShowDialog();
            ShowVozila();
        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            if (dgvVozniPark.SelectedRows.Count > 0)
            {
                int odabranIndeks = dgvVozniPark.SelectedRows[0].Index;
                if (odabranIndeks >= 0 && odabranIndeks < vozila.Count)
                {
                    int odabranoVoziloId = (int)dgvVozniPark.Rows[odabranIndeks].Cells["IdVozila"].Value;
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
                else
                {
                    MessageBox.Show("Molim odaberite željeno vozilo za brisanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else 
            {
                MessageBox.Show("Molimo odaberite željeno vozilo za brisanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

