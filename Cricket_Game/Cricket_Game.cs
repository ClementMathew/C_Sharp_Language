using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cricket_Game.Entities;
using Cricket_Game.Models;

namespace Cricket_Game
{
    internal class Cricket_Game
    {
        static void Main(string[] args)
        {
            var tossType = Game_Manager.Toss();

            if (tossType == TossType.UserBat)
            {
                Game_Manager.UserPlay();
                Game_Manager.ComputerPlay();
            }
            else if (tossType == TossType.UserBowl)
            {
                Game_Manager.ComputerPlay();
                Game_Manager.UserPlay();
            }
            else
            {
                Game_Manager.ComputerPlay();
                Game_Manager.UserPlay();
            }
            if (Computer.Score > User.Score)
            {
                Console.WriteLine("\n--- Computer Won ! ---");
            }
            else
            {
                Console.WriteLine("\n--- You Won ! ---");
            }
        }
    }
}
