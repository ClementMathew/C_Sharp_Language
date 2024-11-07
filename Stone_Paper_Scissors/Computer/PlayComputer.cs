using System;

namespace Stone_Paper_Scissors.Play
{
    internal static class PlayComputer
    {

        public static int GiveValue()
        {
            Random rand = new Random();

            return rand.Next(1, 4);
        }
    }
}
