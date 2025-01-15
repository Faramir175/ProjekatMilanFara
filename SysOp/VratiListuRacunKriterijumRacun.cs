using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class VratiListuRacunKriterijumRacun:SystemOperationBase
    {
        public List<Racun> Result { get; set; }
        private double cena;
        private string criteria = ">";

        public VratiListuRacunKriterijumRacun(double cena)
        {
            this.cena = cena;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.FilterCriteria(new Racun(), criteria + cena).OfType<Racun>().ToList(); 
        }
    }
}
