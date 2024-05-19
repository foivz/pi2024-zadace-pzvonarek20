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
        string korime = "korisnik";
        string lozinka = "password";
        public FrmLogin()
        {
            InitializeComponent();
        }

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
                if (txtUsername.Text == korime && txtPassword.Text == lozinka)
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
    }
}
