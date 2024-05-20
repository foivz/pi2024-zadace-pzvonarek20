using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBusProgramskoRjesenje.Models
{
    public class Vozilo
    {
        public int Id_vozila { get; set; }
        public string model_vozila { get; set; }
        public string naziv_vrste_vozila { get; set;}
        public string tablica_vozila { get; set; }
        public string namjena_vozila { get; set; }
        public string detaljne_informacije { get; set; }
    }
}
