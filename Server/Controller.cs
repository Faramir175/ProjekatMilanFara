using Common.Domain;
using Microsoft.VisualBasic.ApplicationServices;
using SysOp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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

        internal object VratiStavkeRacuna()
        {
            SystemOperationBase so = new VratiStavkeRacunaSysOp();
            so.Execute();
            return ((VratiStavkeRacunaSysOp)so).Result;
        }

        internal Racun KreirajRacun(Racun racun)
        {
            SystemOperationBase so = new KreirajRacun(racun);
            so.Execute();
            return ((KreirajRacun)so).Result;
        }

        internal void KreirajStavke(StavkaRacuna stavka)
        {
            SystemOperationBase so = new KreirajStavke(stavka);
            so.Execute();
        }

        internal void PromeniStavkeRacuna(StavkaRacuna stavka)
        {
            SystemOperationBase so = new PromeniStavkeRacuna(stavka);
            so.Execute();
        }

        internal void PromeniRacun(Racun racun)
        {
            SystemOperationBase so = new PromeniRacun(racun);
            so.Execute();
        }

        internal object VratiListuSviKvalifikacija()
        {
            SystemOperationBase so = new VratiListuSviKvalifikacija();
            so.Execute();
            return ((VratiListuSviKvalifikacija)so).Result;
        }

        internal void UbaciKvalifikacija(Kvalifikacija kvalifikacija)
        {
            SystemOperationBase so = new UbaciKvalifikacija(kvalifikacija);
            so.Execute();
        }

        internal void PromeniKvalifikacija(Kvalifikacija kvalifikacijaZaPromenu)
        {
            SystemOperationBase so = new PromeniKvalifikacija(kvalifikacijaZaPromenu);
            so.Execute();
        }

        internal object VratiListuRacun(Klijent klijent)
        {
            SystemOperationBase so = new VratiListuRacunKriterijumKlijent(klijent);
            so.Execute();
            return ((VratiListuRacunKriterijumKlijent)so).Result;
        }

        internal object VratiListuRacun(Frizer frizer)
        {
            SystemOperationBase so = new VratiListuRacunKriterijumFrizer(frizer);
            so.Execute();
            return ((VratiListuRacunKriterijumFrizer)so).Result;
        }

        internal object VratiListuRacun(Usluga usluga)
        {
            SystemOperationBase so = new VratiListuRacunKriterijumUsluga(usluga);
            so.Execute();
            return ((VratiListuRacunKriterijumUsluga)so).Result;
        }

        internal object VratiListuRacun(double cena)
        {
            SystemOperationBase so = new VratiListuRacunKriterijumRacun(cena);
            so.Execute();
            return ((VratiListuRacunKriterijumRacun)so).Result;
        }
    }
}
