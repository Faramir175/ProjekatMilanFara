using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class KreirajRacun:SystemOperationBase
    {
        private Racun racun;

        public Racun Result { get; set; }

        public KreirajRacun(Racun racun)
        {
            this.racun = racun;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Add(racun);
            racun.IdRacun = (int)broker.GetMaxId(new Racun());
            Debug.WriteLine(racun.IdRacun);
            Result = racun;
        }
    }
}
