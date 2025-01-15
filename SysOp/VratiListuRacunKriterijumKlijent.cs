using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class VratiListuRacunKriterijumKlijent:SystemOperationBase
    {
        public List<Racun> Result { get; set; }
        private Klijent klijent;

        public VratiListuRacunKriterijumKlijent(Klijent klijent)
        {
            this.klijent = klijent;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAllForeignKey(new Racun(), klijent.IdKlijent).OfType<Racun>().ToList(); ;
        }
    }
}
