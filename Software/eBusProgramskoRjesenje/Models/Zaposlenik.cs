﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBusProgramskoRjesenje.Models
{
    public class Zaposlenik : Osoba
    {
        public string Korime { get; set; }
        public string Lozinka { get; set; }
    }
}
