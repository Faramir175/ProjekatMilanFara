using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class PromeniRacun:SystemOperationBase
    {
        Racun racun;
        public PromeniRacun(Racun racun)
        {
            this.racun = racun;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Update(racun, racun.IdRacun);
        }
    }
}
