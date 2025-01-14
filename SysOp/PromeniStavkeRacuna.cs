using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class PromeniStavkeRacuna:SystemOperationBase
    {
        StavkaRacuna stavka;
        public PromeniStavkeRacuna(StavkaRacuna stavka)
        {
            this.stavka = stavka;
        }

        protected override void ExecuteConcreteOperation()
        {
             broker.Update(stavka,stavka.IdRacun);
        }
    }
}
