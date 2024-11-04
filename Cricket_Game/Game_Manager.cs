using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cricket_Game.Entities;

namespace Cricket_Game
{
    internal class Game_Manager
    {

        public static void Toss()
        {
            Random toss = new Random();

            Console.WriteLine("--- Cricket ---");
            Console.WriteLine("\n1 - Heads \n2 - Tails");

            Console.WriteLine("Enter : ");
            int choiceUser = int.Parse(Console.ReadLine());

            int choiceComputer = toss.Next(1, 3);

            if ()
        }

        public static void Play()
        {

            while (true)
            {
                Console.WriteLine("\nEnter b/w 0 and 6 : ");
                int x = int.Parse(Console.ReadLine());

                int y = Computer.GiveValue();
                Console.WriteLine($"From computer : {y}");

                if (x == y)
                {
                    Console.WriteLine("You are out...");
                }
                else
                {

                }

                Check();
            }
        }
        public static void Check()
        {
            if (User == 10 || Computer == 10)
            {
                Console.WriteLine("\n--- Game Finished ---");

                Console.WriteLine("Score : ");
                Console.WriteLine($"User : {User}");
                Console.WriteLine($"Computer : {Computer}");
            }
        }
    }
}
}
