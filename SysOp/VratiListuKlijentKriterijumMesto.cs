using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOp
{
    public class VratiListuKlijentKriterijumMesto:SystemOperationBase
    {
        public List<Klijent> Result { get; set; }
        private Mesto mesto;

        public VratiListuKlijentKriterijumMesto(Mesto mesto)
        {
            this.mesto = mesto;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAllForeignKey(new Klijent(), mesto.IdMesto).OfType<Klijent>().ToList(); 
        }
    }
}
