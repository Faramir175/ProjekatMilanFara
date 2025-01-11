using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]

    public class Mesto
    {
        public int IdMesto { get; set; }
        public int Naziv { get; set; }

    }
}
