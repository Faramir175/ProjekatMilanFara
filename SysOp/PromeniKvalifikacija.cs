using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class PromeniKvalifikacija:SystemOperationBase
    {
        Kvalifikacija kvalifikacija;
        public PromeniKvalifikacija(Kvalifikacija kvalifikacija)
        {
            this.kvalifikacija = kvalifikacija;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Update(kvalifikacija, kvalifikacija.IdKvalifikacija);
        }
    }
}
