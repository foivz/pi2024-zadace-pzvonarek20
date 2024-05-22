using DBLayer;
using eBusProgramskoRjesenje.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBusProgramskoRjesenje.Repositories
{
    internal class RepozitorijVrsteVozila
    {

        //Metoda za dohvaćanje vrste vozila iz baze
        public static List<Vrsta_vozila> GetVrstaVozila()
        {
            List<Vrsta_vozila> vrsteVozila = new List<Vrsta_vozila>();

            string sql = "SELECT * FROM vrsta_vozila";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Vrsta_vozila vrsta_vozila = CreateObject2(reader);
                vrsteVozila.Add(vrsta_vozila);
            }
            reader.Close();
            DB.CloseConnection();

            return vrsteVozila;
        }

        public static Vrsta_vozila GetVrstaVozilaById(int id)
        {
            string sql = $"SELECT * FROM vrsta_vozila WHERE Id_vrste_vozila = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Vrsta_vozila vrsta_Vozila = null;

            if (reader.HasRows == true)
            {
                reader.Read();
                vrsta_Vozila = CreateObject2(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return vrsta_Vozila;
        }

        public static Vrsta_vozila GetVrstaVozilaByName(string name)
        {
            string sql = $"SELECT * FROM vrsta_vozila WHERE naziv_vrste_vozila = '{name}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Vrsta_vozila vrsta_Vozila = null;

            if (reader.HasRows == true)
            {
                reader.Read();
                vrsta_Vozila = CreateObject2(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return vrsta_Vozila;
        }


        //Pohrana dohvaćenih vrsta vozila
        private static Vrsta_vozila CreateObject2(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id_vrste_vozila"].ToString());
            string nazivVrsteVozila = reader["naziv_vrste_vozila"].ToString();
            string opisVrsteVozila = reader["opis_vrste_vozila"].ToString();

            var vrsta_vozila = new Vrsta_vozila
            {
                IdVrsteVozila = id,
                NazivVrsteVozila = nazivVrsteVozila,
                OpisVrsteVozila = opisVrsteVozila,
            };
            return vrsta_vozila;
        }

    }
}
