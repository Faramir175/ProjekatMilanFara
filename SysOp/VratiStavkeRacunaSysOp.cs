using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class VratiStavkeRacunaSysOp:SystemOperationBase
    {
        public List<StavkaRacuna> Result { get; set; }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(new StavkaRacuna()).OfType<StavkaRacuna>().ToList();
            foreach (var item in Result)
            {
                Debug.WriteLine(item.IdRacun);

            }
        }
    }
}
