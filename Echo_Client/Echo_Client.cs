namespace Echo_Client
{

    internal class Echo_Client
    {
        static void Main(string[] args)
        {
            const string ipAddress = "127.0.0.1";
            const int port = 800;

            ClientBuilder client = new ClientBuilder(ipAddress, port);
            client.Run();
        }
    }
}
