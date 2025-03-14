﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Communication
{
    public enum Operation
    {
        LogIn,
        VratiListuSviFrizer,
        VratiListuSviKlijent,
        VratiListuSviUsluga,
        VratiListuSviRacun,
        VratiStavkeRacuna,
        KreirajRacun,
        KreirajStavke,
        PromeniRacun,
        PromeniStavkeRacuna,
        VratiListuSviKvalifikacija,
        UbaciKvalifikacija,
        PromeniKvalifikacija,
        VratiListuRacunKlijent,
        VratiListuRacunUsluga,
        VratiListuRacunFrizer,
        VratiListuRacunRacun,
        VratiJednogKlijenta,
        PretraziRacun,
        PretraziKlijent,
        VratiListuSviMesto,
        VratiListuKlijentKlijent,
        VratiListuKlijentMesto,
        KreirajKlijent,
        ObrisiKlijent,
        VratiJednoMesto,
        PromeniKlijent,
    }
}
