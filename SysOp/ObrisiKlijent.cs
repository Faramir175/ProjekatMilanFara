using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class ObrisiKlijent : SystemOperationBase
    {
        private Klijent klijent;

        public ObrisiKlijent(Klijent klijent)
        {
            this.klijent = klijent;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Delete(new Klijent(),klijent.IdKlijent);

        }
    }
}
