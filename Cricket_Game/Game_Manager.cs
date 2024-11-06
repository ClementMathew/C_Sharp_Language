using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cricket_Game.Entities;
using Cricket_Game.Models;

namespace Cricket_Game
{
    internal class Game_Manager
    {

        public static TossType Toss()
        {
            Random toss = new Random();

            Console.WriteLine("--- Cricket ---");
            Console.WriteLine("\n1 - Heads \n2 - Tails");

            Console.Write("\nEnter : ");
            int choiceUser = int.Parse(Console.ReadLine());

            int findToss = toss.Next(1, 3);

            if (findToss == choiceUser)
            {
                Console.WriteLine("You win the toss...\n1 - Bat\n2 - Ball");
                int batOrBall = int.Parse(Console.ReadLine());

                return batOrBall == 1 ? TossType.UserBat : TossType.UserBowl;
            }
            else
            {
                Console.WriteLine("Computer win the toss....");
                return TossType.Computer;
            }
        }

        public static void ComputerPlay()
        {
            Computer.Score = 0;

            Console.WriteLine("\n--- Computer Playing ---");

            while (true)
            {
                Console.Write("\nEnter b/w 0 and 6 : ");
                int x = int.Parse(Console.ReadLine());

                int y = Computer.GiveValue();
                Console.WriteLine($"From computer : {y}");

                if (x == y)
                {
                    Console.WriteLine($"\nComputer is out...\nRun Scored : {Computer.Score}");
                    break;
                }
                else
                {
                    Computer.Score += y;
                }
            }
        }

        public static void UserPlay()
        {
            User.Score = 0;

            Console.WriteLine("\n--- User Playing ---");

            while (true)
            {
                Console.Write("\nEnter b/w 0 and 6 : ");
                int x = int.Parse(Console.ReadLine());

                int y = Computer.GiveValue();
                Console.WriteLine($"From computer : {y}");

                if (x == y)
                {
                    Console.WriteLine($"\nYou are out...\nRun Scored : {User.Score}");
                    break;
                }
                else
                {
                    User.Score += x;
                }
            }
        }
    }
}

