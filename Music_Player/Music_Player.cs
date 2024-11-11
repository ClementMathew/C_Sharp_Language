using System;

namespace Music_Player
{
    internal class Music_Player
    {
        static void Main(string[] args)
        {
            Player_Manager player = new Player_Manager();

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Start");
                Console.WriteLine("2. Stop");
                Console.WriteLine("3. Previous");
                Console.WriteLine("4. Next");
                Console.WriteLine("5. Apply Filter");
                Console.WriteLine("6. Clear Filter");
                Console.WriteLine("7. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        player.Start();
                        break;

                    case "2":
                        player.Stop();
                        break;

                    case "3":
                        player.Previous();
                        break;

                    case "4":
                        player.Next();
                        break;

                    case "5":
                        player.ApplyFilter();
                        break;

                    case "6":
                        player.ClearFilter();
                        break;

                    case "7":
                        Console.WriteLine("Exiting Music Player.");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
