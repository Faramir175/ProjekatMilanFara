﻿using Common.Communication;
using Common.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client.ServerCommunication
{
    public class Communication
    {
        private Socket socket;
        private Sender sender;
        private Receiver receiver;

        private static Communication instance;
        public static Communication Instance
        {
            get
            {
                if (instance == null) instance = new Communication();
                return instance;
            }
        }

        public void Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9991);
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }

        internal List<Frizer> LoginUser(string username, string password)
        {
            Request request = new Request();
            request.Operation = Operation.LogIn;
            request.Object = new Frizer
            {
                KorisnickoIme = username,
                Sifra = password
            };
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (List<Frizer>)response.Result;
        }

        internal List<Klijent> VratiListuSviKlijent()
        {
            Request request = new Request();
            request.Operation = Operation.VratiListuSviKlijent;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (List<Klijent>)response.Result;
        }

        internal List<Frizer> VratiListuSviFrizer()
        {
            Request request = new Request();
            request.Operation = Operation.VratiListuSviFrizer;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (List<Frizer>)response.Result;
        }

        internal List<Usluga> VratiListuSviUsluga()
        {
            Request request = new Request();
            request.Operation = Operation.VratiListuSviUsluga;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (List<Usluga>)response.Result;
        }

        internal List<Racun> VratiListuSviRacun()
        {
            Request request = new Request();
            request.Operation = Operation.VratiListuSviRacun;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (List<Racun>)response.Result;
        }

        internal List<StavkaRacuna> VratiStavkeRacuna()
        {
            Request request = new Request();
            request.Operation = Operation.VratiStavkeRacuna;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (List<StavkaRacuna>)response.Result;
        }

        internal Racun KreirajRacun(Racun racunZaBazu)
        {
            Request request = new Request();
            request.Operation = Operation.KreirajRacun;
            request.Object = racunZaBazu;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (Racun)response.Result;
        }

        internal void PromeniStavkeRacuna(StavkaRacuna s)
        {
            Request request = new Request();
            request.Operation = Operation.PromeniStavkeRacuna;
            request.Object = s;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
        }

        internal void PromeniRacun(Racun selektovaniRacun)
        {
            Request request = new Request();
            request.Operation = Operation.PromeniRacun;
            request.Object = selektovaniRacun;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
        }

        internal List<Kvalifikacija> VratiListuSviKvalifikacija()
        {
            Request request = new Request();
            request.Operation = Operation.VratiListuSviKvalifikacija;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (List<Kvalifikacija>)response.Result;
        }

        internal void UbaciKvalifikacija(Kvalifikacija novaKvalifikacija)
        {
            Request request = new Request();
            request.Operation = Operation.UbaciKvalifikacija;
            request.Object = novaKvalifikacija;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
        }

        internal void PromeniKvalifikacija(Kvalifikacija kvalifikacijaZaPromenu)
        {
            Request request = new Request();
            request.Operation = Operation.PromeniKvalifikacija;
            request.Object = kvalifikacijaZaPromenu;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
        }

        internal List<Racun> VratiListuRacun(Klijent klijentZaFiltriranje)
        {
            Request request = new Request();
            request.Operation = Operation.VratiListuRacunKlijent;
            request.Object = klijentZaFiltriranje;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (List<Racun>)response.Result;
        }

        internal List<Racun> VratiListuRacun(Frizer frizerZaFiltriranje)
        {
            Request request = new Request();
            request.Operation = Operation.VratiListuRacunFrizer;
            request.Object = frizerZaFiltriranje;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (List<Racun>)response.Result;
        }

        internal List<Racun> VratiListuRacun(Usluga uslugazafiltriranje)
        {
            Request request = new Request();
            request.Operation = Operation.VratiListuRacunUsluga;
            request.Object = uslugazafiltriranje;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (List<Racun>)response.Result;
        }

        internal List<Racun> VratiListuRacun(double cenaZaFiltriranje)
        {
            Request request = new Request();
            request.Operation = Operation.VratiListuRacunRacun;
            request.Object = cenaZaFiltriranje;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (List<Racun>)response.Result;
        }

        internal Klijent VratiJednogKlijenta(int idKlijent)
        {
            Request request = new Request();
            request.Operation = Operation.VratiJednogKlijenta;
            request.Object = idKlijent;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (Klijent)response.Result;
        }

        internal Racun PretraziRacun(Racun selektovaniRacun)
        {
            Request request = new Request();
            request.Operation = Operation.PretraziRacun;
            request.Object = selektovaniRacun;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (Racun)response.Result;
        }

        internal Klijent PretraziKlijent(Klijent klijent)
        {
            Request request = new Request();
            request.Operation = Operation.PretraziKlijent;
            request.Object = klijent;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (Klijent)response.Result;
        }

        internal List<Mesto> VratiListuSviMesto()
        {
            Request request = new Request();
            request.Operation = Operation.VratiListuSviMesto;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (List<Mesto>)response.Result;
        }

        internal List<Klijent> VratiListuKlijent(string imeZaFiltriranje)
        {
            Request request = new Request();
            request.Operation = Operation.VratiListuKlijentKlijent;
            request.Object = imeZaFiltriranje;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (List<Klijent>)response.Result;
        }

        internal List<Klijent> VratiListuKlijent(Mesto mestoZafiltriranje)
        {
            Request request = new Request();
            request.Operation = Operation.VratiListuKlijentMesto;
            request.Object = mestoZafiltriranje;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (List<Klijent>)response.Result;
        }

        internal Klijent KreirajKlijent(Klijent novKlijent)
        {
            Request request = new Request();
            request.Operation = Operation.KreirajKlijent;
            request.Object = novKlijent;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (Klijent)response.Result;
        }

        internal void ObrisiKlijent(Klijent selektovaniKlijent)
        {
            Request request = new Request();
            request.Operation = Operation.ObrisiKlijent;
            request.Object = selektovaniKlijent;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
        }

        internal Mesto VratiJednoMesto(int idMesto)
        {
            Request request = new Request();
            request.Operation = Operation.VratiJednoMesto;
            request.Object = idMesto;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (Mesto)response.Result;
        }

        internal void PromeniKlijent(Klijent selektovaniKlijent)
        {
            Request request = new Request();
            request.Operation = Operation.PromeniKlijent;
            request.Object = selektovaniKlijent;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
        }
    }
}
