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
        public FrmVozniPark()
        {
            InitializeComponent();
        }

        private void FrmVozniPark_Load(object sender, EventArgs e)
        {
            ShowVozila();
        }

        private void ShowVozila()
        {
            List<Vozilo> vozila = RepozitorijVoznogParka.GetVozila();
            dgvVozniPark.DataSource = vozila;

        }
    }
}
