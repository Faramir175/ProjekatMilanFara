using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Klijent
    {
        public int IdKlijent { get; set; }
        public int IdFrizer { get; set; }
        public string ImePrezime { get; set; }
        public string Kontakt { get; set; }
        public string TipKlijenta { get; set; }
        public string Pol { get; set; }
        public int IdMesto { get; set; }

        public override string? ToString()
        {
            return ImePrezime;
        }
    }
}
