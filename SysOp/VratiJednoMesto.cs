using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class VratiJednoMesto:SystemOperationBase
    {
        public Mesto Result { get; set; }
        private int idMesto;

        public VratiJednoMesto(int idMesto)
        {
            this.idMesto = idMesto;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = (Mesto)broker.GetOne(new Mesto(), idMesto);
        }
    }
}
