using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class VratiListuKlijentKriterijumKlijent:SystemOperationBase
    {
        public List<Klijent> Result { get; set; }
        private string ime;
        private string criteria = " like '%";

        public VratiListuKlijentKriterijumKlijent(string ime)
        {
            this.ime = ime;
        }

        protected override void ExecuteConcreteOperation()
        {
            ime = ime + "%'";
            Result = broker.FilterCriteria(new Klijent(), criteria + ime).OfType<Klijent>().ToList();
        }
    }
}
