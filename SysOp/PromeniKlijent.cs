using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class PromeniKlijent:SystemOperationBase
    {
        Klijent klijent;
        public PromeniKlijent(Klijent klijent)
        {
            this.klijent = klijent;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Update(klijent, klijent.IdKlijent);
        }
    }
}
