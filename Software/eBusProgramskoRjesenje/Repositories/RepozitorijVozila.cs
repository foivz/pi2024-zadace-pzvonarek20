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
    internal class RepozitorijVozila
    {
        //Metoda za dohvaćanje svih vozila iz baze
        public static List<Vozilo> GetVozila()
        {
            List<Vozilo> vozila = new List<Vozilo>();

            string sql = "SELECT v.Id_vozila, v.model_vozila, vr.naziv_vrste_vozila, v.tablica_vozila, v.namjena_vozila, v.detaljne_informacije " +
                         "FROM vozilo v " +
                         "JOIN vrsta_vozila vr ON v.Id_vrste_vozila = vr.Id_vrste_vozila";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Vozilo vozilo = CreateObject(reader);
                vozila.Add(vozilo);
            }
            reader.Close();
            DB.CloseConnection();

            return vozila;
        }

        //Pohrana dohvaćenih vozila
        private static Vozilo CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id_vozila"].ToString());
            string modelVozila = reader["model_vozila"].ToString();
            string nazivVrsteVozila = reader["naziv_vrste_vozila"].ToString();
            string tablicaVozila = reader["tablica_vozila"].ToString();
            string namjenaVozila = reader["namjena_vozila"].ToString();
            string detaljneInformacije = reader["detaljne_informacije"].ToString();

            var vozila = new Vozilo
            {
                IdVozila = id,
                ModelVozila = modelVozila,
                IdVrsteVozila = nazivVrsteVozila,
                TablicaVozila = tablicaVozila,
                NamjenaVozila = namjenaVozila,
                DetaljneInformacije = detaljneInformacije
            };
            return vozila;
        }

        //Dohvaćanje podataka za vozilo
        public static Vozilo GetVozilo(int id)
        {
            Vozilo vozilo = null;
            string sql = $"SELECT * FROM vozilo WHERE Id_vozila = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                vozilo = CreateObject3(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return vozilo;

        }

        //Pohrana dohvaćenog vozila
        private static Vozilo CreateObject3(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id_vozila"].ToString());
            string modelVozilaPromjena = reader["model_vozila"].ToString();
            string nazivVrsteVozilaPromjena = reader["Id_vrste_vozila"].ToString();
            string tablicaVozilaPromjena = reader["tablica_vozila"].ToString();
            string namjenaVozilaPromjena = reader["namjena_vozila"].ToString();
            string detaljneInformacijePromjena = reader["detaljne_informacije"].ToString();

            var vozilo = new Vozilo
            {
                IdVozila = id,
                ModelVozila = modelVozilaPromjena,
                IdVrsteVozila = nazivVrsteVozilaPromjena,
                TablicaVozila = tablicaVozilaPromjena,
                NamjenaVozila = namjenaVozilaPromjena,
                DetaljneInformacije = detaljneInformacijePromjena
            };
            return vozilo;
        }

    }
}
