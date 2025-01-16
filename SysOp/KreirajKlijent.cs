using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class KreirajKlijent:SystemOperationBase
    {
        private Klijent klijent;

        public Klijent Result { get; set; }

        public KreirajKlijent(Klijent klijent)
        {
            this.klijent = klijent;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Add(klijent);
            klijent.IdKlijent = (int)broker.GetMaxId(new Klijent());
            Debug.WriteLine(klijent.IdKlijent);
            Result = klijent;
        }
    }
}
