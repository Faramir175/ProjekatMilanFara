using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class VratiStavkeRacunaSysOp:SystemOperationBase
    {
        private Racun selektovaniRacun;
        public List<StavkaRacuna> Result { get; set; }

        public VratiStavkeRacunaSysOp(Racun selektovaniRacun)
        {
            this.selektovaniRacun = selektovaniRacun;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAllJoin(new StavkaRacuna(),selektovaniRacun).OfType<StavkaRacuna>().ToList();

        }
    }
}
