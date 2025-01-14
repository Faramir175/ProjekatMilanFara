using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class VratiListuSviKvalifikacija:SystemOperationBase
    {
        public List<Kvalifikacija> Result { get; set; }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(new Kvalifikacija()).OfType<Kvalifikacija>().ToList();

        }
    }
}
