using Azure;
using Common.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Common;
using Response = Common.Communication.Response;
using Operation = Common.Communication.Operation;
using Microsoft.VisualBasic.ApplicationServices;
using Common.Domain;
using System.ComponentModel;

namespace Server
{
    public class ClientHandler
    {
        private Socket klijentSocket;
        private Sender sender;
        private Receiver receiver;

        public ClientHandler(Socket klijentSocket)
        {
            this.klijentSocket = klijentSocket;
            sender = new Sender(klijentSocket);
            receiver = new Receiver(klijentSocket);
        }

        public void HandleRequest()
        {
            try
            {
                while (true)
                {
                    Request request = receiver.Receive<Request>();
                    Response response = ProcessRequest(request);
                    sender.Send(response);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private Response ProcessRequest(Request request)
        {
            Response response = new Response();
            try
            {
                switch (request.Operation)
                {
                    case Operation.LogIn:
                        response.Result = Controller.Instance.LoginUser((Frizer)request.Object);
                        break;
                    case Operation.VratiListuSviKlijent:
                        response.Result = Controller.Instance.VratiListuSviKlijent();
                        break;
                    case Operation.VratiListuSviFrizer:
                        response.Result = Controller.Instance.VratiListuSviFrizer();
                        break;
                    case Operation.VratiListuSviUsluga:
                        response.Result = Controller.Instance.VratiListuSviUsluga();
                        break;
                    case Operation.VratiListuSviRacun:
                        response.Result = Controller.Instance.VratiListuSviRacun();
                        break;
                    case Operation.VratiStavkeRacuna:
                        response.Result = Controller.Instance.VratiStavkeRacuna();
                        break;
                    case Operation.KreirajRacun:
                        response.Result = Controller.Instance.KreirajRacun((Racun)request.Object);
                        break;
                    case Operation.KreirajStavke:
                        Controller.Instance.KreirajStavke((StavkaRacuna)request.Object);
                        break;
                    case Operation.PromeniStavkeRacuna:
                        Controller.Instance.PromeniStavkeRacuna((StavkaRacuna)request.Object);
                        break;
                    case Operation.PromeniRacun:
                        Controller.Instance.PromeniRacun((Racun)request.Object);
                        break;
                    case Operation.VratiListuSviKvalifikacija:
                        response.Result = Controller.Instance.VratiListuSviKvalifikacija();
                        break;
                    default:
                        response.Exception = new Exception("Operation is not implemented!");
                    break;
                }
            }
            catch (Exception ex)
            {
                response.Exception = new Exception(ex.Message);
            }
            return response;
        }

    }
}