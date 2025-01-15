using Common.Communication;
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

        internal void KreirajStavke(StavkaRacuna stavka)
        {
            Request request = new Request();
            request.Operation = Operation.KreirajStavke;
            request.Object = stavka;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
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
    }
}
