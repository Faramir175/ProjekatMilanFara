using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class FrK
    {
        public int IdFrizer { get; set; }
        public DateOnly DatumSticanja { get; set; } 
        public string Institucija { get; set; }
        public int IdKvalifikacija { get; set; }
    }
}
