using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class ClientBuilder
    {
        private string _ipAddress = "127.0.0.1";
        private int _port = 800;
        private TcpClient _client;

        private void Builder()
        {
            var _ip = IPAddress.Parse(_ipAddress);

            _client = new TcpClient();
            _client.Connect(_ip, _port);

            Console.WriteLine("Connected to server...");
        }
        public void Run()
        {
            Builder();

            while (true)
            {
                Console.WriteLine("Enter : ");
                string messageClient = Console.ReadLine();
                byte[] dataClient = Encoding.ASCII.GetBytes(messageClient);
                _client.GetStream().Write(dataClient, 0, dataClient.Length);

                Console.WriteLine("Message sent...");

                if (messageClient == "exit")
                {
                    _client.Close();
                    break;
                }

                var buffer = new byte[1024];
                var dataServer = _client.GetStream().Read(buffer, 0, buffer.Length);
                var messageServer = Encoding.ASCII.GetString(buffer, 0, dataServer);

                Console.WriteLine($"Server : {messageServer}");

                if (messageServer == "exit")
                {
                    _client.Close();
                    break;
                }
            }
        }
    }
}
