using DBLayer;
using eBusProgramskoRjesenje.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBusProgramskoRjesenje.Repositories
{
    internal class RepozitorijZaposlenika
    {
        public static Zaposlenik GetZaposlenik(string korime)
        {
            string sql = $"SELECT * FROM zaposlenik WHERE korime = '{korime}'";
            return FetchZaposlenik(sql);
        }

        public static Zaposlenik GetZaposlenik(int id)
        {
            string sql = $"SELECT * FROM zaposlenik WHERE Id_zaposlenika = {id}";
            return FetchZaposlenik(sql);
        }

        private static Zaposlenik FetchZaposlenik(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Zaposlenik zaposlenik = null;

            if(reader.HasRows == true)
            {
                reader.Read();
                zaposlenik = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return zaposlenik;
        }

        private static Zaposlenik CreateObject(SqlDataReader reader)
        { 
            int id = int.Parse(reader["Id_zaposlenika"].ToString());
            string imeZaposlenika = reader["ime_zaposlenika"].ToString();
            string prezimeZaposlenika = reader["prezime_zaposlenika"].ToString();
            string korisnickoIme = reader["korime"].ToString();
            string lozinka = reader["lozinka"].ToString();

            var zaposlenik = new Zaposlenik
            {
                Id = id,
                Ime = imeZaposlenika,
                Prezime = prezimeZaposlenika,
                Korime = korisnickoIme,
                Lozinka = lozinka
            };
            return zaposlenik;
        }
    }
}
