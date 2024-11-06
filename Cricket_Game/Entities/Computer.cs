using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
