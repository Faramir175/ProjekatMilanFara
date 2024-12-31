using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Racun
    {
        public int IdRacun { get; set; }
        public DateTime Datum { get; set; }
        public int Popust { get; set; }
        public double UkupanIznos { get; set; }
        public int IdFrizer { get; set; }
        public int IdKlijent { get; set; }


    }
}
