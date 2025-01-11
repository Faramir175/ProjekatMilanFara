using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        private Socket serverSocket;

        public Server()
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Start()
        {
            try
            {
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9991);
                serverSocket.Bind(endpoint);
                serverSocket.Listen(10);

                Thread listener = new Thread(Listen);
                listener.Start();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            
        }
        public void Listen()
        {
            Socket klijentSocket = serverSocket.Accept();

            ClientHandler handler = new ClientHandler(klijentSocket);
            Thread thread = new Thread(handler.HandleRequest);
            thread.Start();
        }
        public void Stop()
        {
            serverSocket?.Close();
        }
    }
}
