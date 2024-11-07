namespace Echo_server
{

    internal class Echo_Server
    {
        static void Main(string[] args)
        {
            const string ipAddress = "127.0.0.1";
            const int port = 800;

            ServerBuilder server = new ServerBuilder(ipAddress, port);
            server.Run();
        }
    }
}
