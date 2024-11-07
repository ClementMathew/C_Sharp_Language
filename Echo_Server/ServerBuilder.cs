using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Echo_server
{
    public class ServerBuilder
    {
        private readonly string _ip;
        private readonly int _port;
        private Socket _socket;
        private TcpListener _listener;

        public ServerBuilder(string ipAddress, int port)
        {
            _ip = ipAddress;
            _port = port;
        }

        private void Builder()
        {
            _listener = new TcpListener(IPAddress.Parse(_ip), _port);

            _listener.Start();
            Console.WriteLine("Server started listening...");
        }

        public void Run()
        {
            Builder();

            _socket = _listener.AcceptSocket();
            Console.WriteLine("Client connected...");

            while (true)
            {
                byte[] bytes = new byte[1024];
                int dataClient = _socket.Receive(bytes);
                string messageClient = Encoding.ASCII.GetString(bytes, 0, dataClient);

                Console.WriteLine($"Client : {messageClient}");


                byte[] messageServer = Encoding.ASCII.GetBytes(messageClient);
                _socket.Send(messageServer);

                Console.WriteLine("Message send....");
            }
        }
    }
}
