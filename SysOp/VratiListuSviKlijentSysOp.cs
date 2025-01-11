using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class VratiListuSviKlijentSysOp:SystemOperationBase
    {
        public List<Klijent> Result { get; set; }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(new Klijent()).OfType<Klijent>().ToList();

        }
    }
}
