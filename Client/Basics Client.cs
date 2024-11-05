using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Client
    {
        static void Main(string[] args)
        {
            var clientBuilder = new ClientBuilder();
            clientBuilder.Run();
        }
    }
}
