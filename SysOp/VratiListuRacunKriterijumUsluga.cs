using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class VratiListuRacunKriterijumUsluga:SystemOperationBase
    {
        public List<Racun> Result { get; set; }
        private Usluga usluga;

        public VratiListuRacunKriterijumUsluga(Usluga usluga)
        {
            this.usluga = usluga;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAllForeignKeyJoin(new Racun(),new StavkaRacuna(), usluga.IdUsluga).OfType<Racun>().ToList(); 
        }
    }
}
