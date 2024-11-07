using System;

namespace Sum_of_Two_Numbers
{
    internal class Sum_of_Two_Numbers_by_Func
    {
        static void Main(string[] args)
        {
            Func<int, int, int> sumFunc = (a, b) => a + b;

            Console.WriteLine(sumFunc(5, 7));
        }
    }
}
