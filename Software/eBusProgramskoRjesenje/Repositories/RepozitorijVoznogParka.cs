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
