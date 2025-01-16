using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class VratiListuSviMesto:SystemOperationBase
    {
        public List<Mesto> Result { get; set; }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(new Mesto()).OfType<Mesto>().ToList();

        }
    }
}
