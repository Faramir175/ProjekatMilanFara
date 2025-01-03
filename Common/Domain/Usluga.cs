using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Usluga
    {
        public int IdUsluga { get; set; }
        public string Naziv { get; set; }
        public int Cena { get; set; }
        public int Trajanje { get; set; }

        public override string? ToString()
        {
            return Naziv;
        }
    }
}
