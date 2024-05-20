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
            string vrsta_vozila = reader["vrsta_vozila"].ToString();
            string tablica_vozila = reader["tablica_vozila"].ToString();
            string namjena_vozila = reader["namjena_vozila"].ToString();
            string detaljne_informacije = reader["detaljne_informacije"].ToString();

            var vozilo = new Vozilo
            {
                Id_vozila = id,
                vrsta_vozila = vrsta_vozila,
                tablica_vozila = tablica_vozila,
                namjena_vozila = namjena_vozila,
                detaljne_informacije = detaljne_informacije
            };
            return vozilo;
        }

        public static void DodajNovoVozilo(string vrstaVozila, string tablicaVozila, string namjenaVozila, string detaljneInformacije)
        {
            string sql = $"INSERT INTO vozilo (vrsta_vozila, tablica_vozila, namjena_vozila, detaljne_informacije) " +
                         $"VALUES ('{vrstaVozila}', '{tablicaVozila}', '{namjenaVozila}', '{detaljneInformacije}')";

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

    }
}
