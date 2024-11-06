using System;
using System.Net.Sockets;
using System.Text;

namespace Echo_Client
{
    public class ClientBuilder
    {
        private readonly string _ip;
        private readonly int _port;
        private TcpClient _client;

        public ClientBuilder(string ipAddress, int port)
        {
            _ip = ipAddress;
            _port = port;
        }

        private void Builder()
        {
            _client = new TcpClient();

            _client.Connect(_ip, _port);
            Console.WriteLine("Connected to server...");
        }

        public void Run()
        {
            Builder();

            while (true)
            {
                Console.Write("Enter : ");
                var messageClient = Console.ReadLine();
                byte[] dataClient = Encoding.ASCII.GetBytes(messageClient);
                _client.GetStream().Write(dataClient, 0, dataClient.Length);

                Console.WriteLine("Message send...");

                byte[] bytes = new byte[1024];
                var dataServer = _client.GetStream().Read(bytes, 0, bytes.Length);
                var messageServer = Encoding.ASCII.GetString(bytes, 0, dataServer);

                Console.WriteLine($"Server : {messageServer}");
            }
        }
    }
}
