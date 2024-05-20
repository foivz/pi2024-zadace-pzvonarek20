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
        public static Vozilo GetVozilo(int id)
        {
            Vozilo vozilo = null;
            string sql = $"SELECT * FROM vozilo WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            { 
                reader.Read();  
                vozilo = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return vozilo;

        }

        public static List<Vozilo> GetVozila()
        { 
            List<Vozilo> vozila = new List<Vozilo>();

            string sql = "SELECT * FROM vozilo";
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

        private static Vozilo CreateObject(SqlDataReader reader)
        { 
            int id = int.Parse(reader["Id_vozila"].ToString());
            string model_vozila = reader["model_vozila"].ToString();
            string id_vrste_vozila = reader["Id_vrste_vozila"].ToString();
            string tablica_vozila = reader["tablica_vozila"].ToString();
            string namjena_vozila = reader["namjena_vozila"].ToString();
            string detaljne_informacije = reader["detaljne_informacije"].ToString();

            var vozilo = new Vozilo
            {
                Id_vozila = id,
                model_vozila=model_vozila,
                Id_vrste_vozila = id_vrste_vozila,
                tablica_vozila = tablica_vozila,
                namjena_vozila = namjena_vozila,
                detaljne_informacije = detaljne_informacije
            };
            return vozilo;
        }

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
        private static Vrsta_vozila CreateObject2(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id_vrste_vozila"].ToString());
            string naziv_vrste_vozila = reader["naziv_vrste_vozila"].ToString();
            string opis_vrste_vozila = reader["opis_vrste_vozila"].ToString();

            var vrsta_vozila = new Vrsta_vozila
            {
                Id_vrste_vozila = id,
                Naziv_vrste_vozila = naziv_vrste_vozila,
                Opis_vrste_vozila = opis_vrste_vozila,
            };
            return vrsta_vozila;
        }

    }
}
