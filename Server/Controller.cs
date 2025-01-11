using Common.Domain;
using Microsoft.VisualBasic.ApplicationServices;
using SysOp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Controller
    {
        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null) instance = new Controller();
                return instance;
            }
        }

        internal object LoginUser(Frizer user)
        {
            SystemOperationBase so = new LogInSysOp(user);
            so.Execute();
            return ((LogInSysOp)so).Result;
        }

        internal object VratiListuSviKlijent()
        {
            SystemOperationBase so = new VratiListuSviKlijentSysOp();
            so.Execute();
            return ((VratiListuSviKlijentSysOp)so).Result;
        }

        internal object VratiListuSviFrizer()
        {
            SystemOperationBase so = new VratiListuSviFrizerSysOp();
            so.Execute();
            return ((VratiListuSviFrizerSysOp)so).Result;
        }

        internal object VratiListuSviUsluga()
        {
            SystemOperationBase so = new VratiListuSviUslugaSysOp();
            so.Execute();
            return ((VratiListuSviUslugaSysOp)so).Result;
        }

        internal object VratiListuSviRacun()
        {
            SystemOperationBase so = new VratiListuSviRacunSysOp();
            so.Execute();
            return ((VratiListuSviRacunSysOp)so).Result;
        }

        internal object VratiStavkeRacuna(Racun selektovaniRacun)
        {
            SystemOperationBase so = new VratiStavkeRacunaSysOp(selektovaniRacun);
            so.Execute();
            return ((VratiStavkeRacunaSysOp)so).Result;
        }
    }
}
