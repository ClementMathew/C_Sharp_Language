using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class ServerBuilder
    {
        private string _ipAddress = "127.0.0.1";
        private int _port = 800;
        private TcpListener _listener;
        private Socket _socket;

        private void Buider()
        {
            var ip = IPAddress.Parse(_ipAddress);

            _listener = new TcpListener(ip, _port);
            _listener.Start();

            Console.WriteLine("Server started listening...");
        }

        public void Run()
        {
            Buider();

            _socket = _listener.AcceptSocket();
            Console.WriteLine("Client connected...");

            while (true)
            {
                var buffer = new byte[1024];
                var dataClient = _socket.Receive(buffer);
                var messageClient = Encoding.ASCII.GetString(buffer, 0, dataClient);
                Console.WriteLine($"Client : {messageClient}");

                if (messageClient == "exit")
                {
                    _socket.Close();
                    _listener.Stop();
                    break;
                }

                Console.WriteLine("Enter : ");
                string messageServer = Console.ReadLine();
                byte[] dataServer = Encoding.ASCII.GetBytes(messageServer);

                _socket.Send(dataServer);

                Console.WriteLine("Message sent...");

                if (messageServer == "exit")
                {
                    _socket.Close();
                    _listener.Stop();
                    break;
                }
            }
        }
    }
}

