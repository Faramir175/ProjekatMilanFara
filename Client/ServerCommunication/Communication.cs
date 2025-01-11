using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
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

        internal List<StavkaRacuna> VratiStavkeRacuna(Racun selektovaniRacun)
        {
            Request request = new Request();
            request.Operation = Operation.VratiStavkeRacuna;
            request.Object = selektovaniRacun;
            sender.Send(request);

            Response response = receiver.Receive<Response>();
            if (response.Exception != null)
            {
                throw response.Exception;
            }
            return (List<StavkaRacuna>)response.Result;
        }
    }
}
