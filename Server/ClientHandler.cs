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
                    case Operation.PromeniStavkeRacuna:
                        Controller.Instance.PromeniStavkeRacuna((StavkaRacuna)request.Object);
                        break;
                    case Operation.PromeniRacun:
                        Controller.Instance.PromeniRacun((Racun)request.Object);
                        break;
                    case Operation.VratiListuSviKvalifikacija:
                        response.Result = Controller.Instance.VratiListuSviKvalifikacija();
                        break;
                    case Operation.UbaciKvalifikacija:
                        Controller.Instance.UbaciKvalifikacija((Kvalifikacija)request.Object);
                        break;
                    case Operation.PromeniKvalifikacija:
                        Controller.Instance.PromeniKvalifikacija((Kvalifikacija)request.Object);
                        break;
                    case Operation.VratiListuRacunKlijent:
                        response.Result = Controller.Instance.VratiListuRacun((Klijent)request.Object);
                        break;
                    case Operation.VratiListuRacunFrizer:
                        response.Result = Controller.Instance.VratiListuRacun((Frizer)request.Object);
                        break;
                    case Operation.VratiListuRacunUsluga:
                        response.Result = Controller.Instance.VratiListuRacun((Usluga)request.Object);
                        break;
                    case Operation.VratiListuRacunRacun:
                        response.Result = Controller.Instance.VratiListuRacun((double)request.Object);
                        break;
                    case Operation.VratiJednogKlijenta:
                        response.Result = Controller.Instance.VratiJednogKlijenta((int)request.Object);
                        break;
                    case Operation.PretraziRacun:
                        response.Result = Controller.Instance.PretraziRacun((Racun)request.Object);
                        break;
                    case Operation.PretraziKlijent:
                        response.Result = Controller.Instance.PretraziKlijent((Klijent)request.Object);
                        break;
                    case Operation.VratiListuSviMesto:
                        response.Result = Controller.Instance.VratiListuSviMesto();
                        break;
                    default:
                        response.Exception = new Exception("Operation is not implemented!");
                    break;
                    case Operation.VratiListuKlijentKlijent:
                        response.Result = Controller.Instance.VratiListuKlijent((string)request.Object);
                        break;
                    case Operation.VratiListuKlijentMesto:
                        response.Result = Controller.Instance.VratiListuKlijent((Mesto)request.Object);
                        break;
                    case Operation.KreirajKlijent:
                        response.Result = Controller.Instance.KreirajKlijent((Klijent)request.Object);
                        break;
                    case Operation.ObrisiKlijent:
                        Controller.Instance.ObrisiKlijent((Klijent)request.Object);
                        break;
                    case Operation.VratiJednoMesto:
                        response.Result = Controller.Instance.VratiJednoMesto((int)request.Object);
                        break;
                    case Operation.PromeniKlijent:
                        Controller.Instance.PromeniKlijent((Klijent)request.Object);
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