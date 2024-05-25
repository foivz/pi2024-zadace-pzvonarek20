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
    public partial class FrmLogin : Form
    {
        public static Zaposlenik LoggedZaposlenik {  get; set; }
        public FrmLogin()
        {
            InitializeComponent();
            txtUsername.KeyDown += new KeyEventHandler(OnKeyDownHandler);
            txtPassword.KeyDown += new KeyEventHandler(OnKeyDownHandler);
        }

        //Gumb za logiranje (provjeru korisnika)
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                LoggedZaposlenik = RepozitorijZaposlenika.GetZaposlenik(txtUsername.Text);
                if (LoggedZaposlenik != null && LoggedZaposlenik.Lozinka.Trim() == txtPassword.Text)
                {
                    FrmVozniPark frmVozniPark = new FrmVozniPark();
                    Hide();
                    frmVozniPark.ShowDialog();
                    Close();
                }
                else 
                {
                    MessageBox.Show("Krivi unos podataka!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        //Mogucnost logiranja pritiskom na enter
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                e.SuppressKeyPress = true;
                btnLogin_Click(sender, e);
            }
        }

    }
}
