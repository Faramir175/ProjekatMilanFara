using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class KreirajStavke:SystemOperationBase
    {
        private StavkaRacuna stavka;

        public KreirajStavke(StavkaRacuna stavka)
        {
            this.stavka = stavka;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Add(stavka);
        }
    }
}
