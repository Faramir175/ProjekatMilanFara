using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class VratiListuSviRacunSysOp:SystemOperationBase    
    {
        public List<Racun> Result { get; set; }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(new Racun()).OfType<Racun>().ToList();

        }
    }
}
