using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Task_Run
{
    internal class Task_Run
    {
        static async Task<int> Multiply(int number)
        {
            await Task.Delay(1000);

            return number * 2;
        }

        public static async Task Main()
        {
            List<Task<int>> tasks = new List<Task<int>>()
            {
                Task.Run(() => Multiply(2)),
                Task.Run(() => Multiply(5)),
                Task.Run(() => Multiply(8))
            };

            int[] results = await Task.WhenAll(tasks);
            Console.WriteLine(string.Join(", ", results));
        }
    }
}
