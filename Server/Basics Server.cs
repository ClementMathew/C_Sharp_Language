namespace Server
{
    internal class Server
    {
        static void Main(string[] args)
        {
            ServerBuilder serverBuilder = new ServerBuilder();
            serverBuilder.Run();
        }
    }
}
