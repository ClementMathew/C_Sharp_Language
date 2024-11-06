using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo_Client
{

    internal class Echo_Client
    {
        static void Main(string[] args)
        {
            const string ipAddress = "127.0.0.1";
            const int port = 800;

            var client = new ClientBuilder(ipAddress, port);
            client.Run();
        }
    }
}
