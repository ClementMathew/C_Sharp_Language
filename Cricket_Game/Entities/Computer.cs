using System;

namespace Cricket_Game.Entities
{
    internal static class Computer
    {
        public static int Score { get; set; }
        public static int GiveValue()
        {
            Random random = new Random();

            return random.Next(0, 6);
        }
    }
}
