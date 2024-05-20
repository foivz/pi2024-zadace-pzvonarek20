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

        private void btnDodajNovoVozilo_Click(object sender, EventArgs e)
        {
            
            string vrstaVozila = txtVrstaVozila.Text;
            string tablicaVozila = txtTablicaVozila.Text;
            string namjenaVozila = txtNamjenaVozila.Text;
            string detaljneInformacije = txtDetaljneInformacije.Text;

            RepozitorijVoznogParka.DodajNovoVozilo(vrstaVozila, tablicaVozila, namjenaVozila, detaljneInformacije);
            MessageBox.Show("Vozilo je uspiješno dodano u bazu podataka.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }


    }
}
