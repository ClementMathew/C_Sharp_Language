using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class Server
    {
        static void Main(string[] args)
        {
            var serverBuilder = new ServerBuilder();
            serverBuilder.Run();
        }
    }
}
