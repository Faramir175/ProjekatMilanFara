using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class PretraziRacun:SystemOperationBase
    {
        public Racun Result { get; set; }
        private Racun racun;

        public PretraziRacun(Racun racun)
        {
            this.racun = racun;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = (Racun)broker.GetOne(new Racun(), racun.IdRacun);
        }
    }
}
