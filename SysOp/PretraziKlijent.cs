using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class PretraziKlijent:SystemOperationBase
    {
        public Klijent Result { get; set; }
        private Klijent klijent;

        public PretraziKlijent(Klijent klijent)
        {
            this.klijent = klijent;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = (Klijent)broker.GetOne(new Klijent(), klijent.IdKlijent);
        }
    }
}
