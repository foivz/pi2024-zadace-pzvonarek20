using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBusProgramskoRjesenje.Models
{
    public class Vozilo
    {
        [DisplayName("ID vozila")]
        public int IdVozila { get; set; }

        [DisplayName("Model vozila")]
        public string ModelVozila { get; set; }

        [DisplayName("Vrsta vozila")]
        public string IdVrsteVozila { get; set;}

        [DisplayName("Tablica vozila")]
        public string TablicaVozila { get; set; }

        [DisplayName("Namjena vozila")]
        public string NamjenaVozila { get; set; }

        [DisplayName("Detaljne informacije")]
        public string DetaljneInformacije { get; set; }
    }
}
