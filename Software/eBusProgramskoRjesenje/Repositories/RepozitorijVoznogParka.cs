using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using eBusProgramskoRjesenje.Models;

namespace eBusProgramskoRjesenje.Repositories
{
    public class RepozitorijVoznogParka
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
                ModelVozila=modelVozila,
                IdVrsteVozila = nazivVrsteVozila,
                TablicaVozila = tablicaVozila,
                NamjenaVozila = namjenaVozila,
                DetaljneInformacije = detaljneInformacije
            };
            return vozila;
        }

        //Metoda za dodavanje novog vozila u bazu
        public static void DodajNovoVozilo(string modelVozila, int vrstaVozila, string tablicaVozila, string namjenaVozila, string detaljneInformacije)
        {
            string sql = $"INSERT INTO vozilo (model_vozila,  Id_vrste_vozila, tablica_vozila, namjena_vozila, detaljne_informacije) " +
                         $"VALUES ('{modelVozila}', '{vrstaVozila}', '{tablicaVozila}', '{namjenaVozila}', '{detaljneInformacije}')";

            try
            {
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Došlo je do greške prilikom dodavanja novog vozila: {ex.Message}");
            }
            finally
            {
                DB.CloseConnection();
            }
        }

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

        //Metoda za brisanje postojećeg vozila iz baze
        public static bool ObrisiVozilo(int voziloId)
        {
            try 
            {
                string sql = $"DELETE FROM vozilo WHERE Id_vozila = {voziloId}";
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška prilikom brisanja vozila: " + ex.Message);
                return false;
            }
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

        public static bool UpdateVozilo(int IdVozila, string ModelVozila, int IdVrsteVozila, string TablicaVozila, string NamjenaVozila, string DetaljneInformacijeVozila)
        {
            try
            {
                string sql = $"UPDATE vozilo SET model_vozila = '{ModelVozila}', Id_vrste_vozila = {IdVrsteVozila}, tablica_vozila = '{TablicaVozila}', namjena_vozila = '{NamjenaVozila}', detaljne_informacije = '{DetaljneInformacijeVozila}' WHERE Id_vozila = {IdVozila}";
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška prilikom promjene podataka vozila: " + ex.Message);
                return false;
            }
        }
    }
}
