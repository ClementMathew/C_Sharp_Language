using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Echo_Client
{
    internal class ClientBuilder
    {
        private TcpClient _client;
        private const string ipAddress = "127.0.0.1";
        private const int port = 5000;

        private void Build()
        {
            var ip = IPAddress.Parse(ipAddress);
            _client = new TcpClient();

            _client.Connect(ip, port);
            Console.WriteLine("Connected to Server...");
        }

        public void Start()
        {
            Build();


            while (true)
            {
                Console.Write("Client: ");
                var message = Console.ReadLine();

                if (string.IsNullOrEmpty(message)) continue;

                byte[] data = Encoding.ASCII.GetBytes(message);
                _client.GetStream().Write(data, 0, data.Length);

                byte[] response = new byte[1024];

                var dataS = _client.GetStream().Read(response, 0, response.Length);
                var responseText = Encoding.ASCII.GetString(response, 0, dataS);

                Console.WriteLine($"Server: {responseText}");
            }
        }

        public void Stop()
        {
            _client.Close();
        }
    }
}
