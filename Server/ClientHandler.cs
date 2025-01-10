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
                        response.Result = "The end!";
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