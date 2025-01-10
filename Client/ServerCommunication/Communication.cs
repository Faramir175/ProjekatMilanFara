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
        Socket socket;
        private static Communication instance;
        public static Communication Instance { get { if (instance == null) instance = new Communication(); return instance; } }
        public Communication()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Connect()
        {
            socket.Connect("127.0.0.1", 9991);
        }
    }
}
