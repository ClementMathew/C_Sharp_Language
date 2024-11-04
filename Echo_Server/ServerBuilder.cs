using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Echo_Server
{
    internal class ServerBuilder
    {
        private TcpListener _listener;
        private Socket _socket;
        private const string ipAddress = "127.0.0.1";
        private const int port = 5000;

        private void Build()
        {
            var ip = IPAddress.Parse(ipAddress);
            _listener = new TcpListener(ip, port);

            _listener.Start();
            Console.WriteLine("Server listening...");
        }

        public void Run()
        {
            Build();

            while (true)
            {
                Socket socket = _listener.AcceptSocket();
                Console.WriteLine("Client connected");

                // Create a buffer for receiving data

                var buffer = new byte[1024];
                var dataLength = socket.Receive(buffer);
                string message = Encoding.ASCII.GetString(buffer, 0, dataLength);
                Console.WriteLine($"Message received: {message}");

                // Respond to the client

                Console.Write("Server: ");
                string response = Console.ReadLine(); // Read response from server
                byte[] responseData = Encoding.ASCII.GetBytes(response);
                socket.Send(responseData); // Send response to client
                Console.WriteLine($"Response sent: {response}");

                socket.Close(); // Close the socket after interaction
            }
                catch (Exception ex)
                {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
}
