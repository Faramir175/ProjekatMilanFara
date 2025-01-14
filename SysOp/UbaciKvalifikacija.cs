using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class UbaciKvalifikacija:SystemOperationBase
    {
        private Kvalifikacija kvalifikacija;

        public UbaciKvalifikacija(Kvalifikacija kvalifikacija)
        {
            this.kvalifikacija = kvalifikacija;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Add(kvalifikacija);
        }
    }
}
