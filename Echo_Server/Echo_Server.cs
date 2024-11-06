using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo_server
{

    internal class Echo_Server
    {
        static void Main(string[] args)
        {
            const string ipAddress = "127.0.0.1";
            const int port = 800;

            var server = new ServerBuilder(ipAddress, port);
            server.Run();
        }
    }
}
