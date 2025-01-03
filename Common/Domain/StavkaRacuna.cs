using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class StavkaRacuna
    {
        public int IdRacun { get; set; }
        public int Rb { get; set; }
        public double Iznos { get; set; }
        public int Kolicina { get; set; }
        public int Cena { get; set; }
        public int IdUsluga { get; set; }
        public string NazivUsluga { get; set; }

    }
}
