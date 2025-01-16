using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class VratiJednogKlijenta:SystemOperationBase
    {
        public Klijent Result { get; set; }
        private int idKlijent;

        public VratiJednogKlijenta(int idKlijent)
        {
            this.idKlijent = idKlijent;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = (Klijent)broker.GetOne(new Klijent(), idKlijent);
        }
    }
}
