using System;

namespace Learning
{
    internal class Multicast_Delegate
    {
        static void Main(string[] args)
        {
            Func<int, int, int> del = (a, b) => a + b;

            del += (a, b) => a - b;

            foreach (Func<int, int, int> item in del.GetInvocationList())
            {
                Console.WriteLine(item(5, 10));
            }
        }
    }
}
