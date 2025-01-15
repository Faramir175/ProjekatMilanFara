using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class VratiListuRacunKriterijumFrizer:SystemOperationBase
    {
        public List<Racun> Result { get; set; }
        private Frizer frizer;

        public VratiListuRacunKriterijumFrizer(Frizer frizer)
        {
            this.frizer = frizer;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAllForeignKey2(new Racun(), frizer.IdFrizer).OfType<Racun>().ToList(); ;
        }
    }
}
