using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBusProgramskoRjesenje.Models
{
    public class Vozilo
    {
        public int IdVozila { get; set; }
        public string ModelVozila { get; set; }
        public string IdVrsteVozila { get; set;}
        public string TablicaVozila { get; set; }
        public string NamjenaVozila { get; set; }
        public string DetaljneInformacije { get; set; }
    }
}
