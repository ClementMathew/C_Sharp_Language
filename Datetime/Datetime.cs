using System;

namespace Datetime
{
    internal class Datetime
    {
        static void Main(string[] args)
        {
            // DateTime functions.

            DateTime dt = DateTime.Now;
            Console.WriteLine($"Datetime now : {dt}");

            DateTime dtu = DateTime.UtcNow;
            Console.WriteLine($"Datetime utcnow : {dtu} \n");

            Console.WriteLine($"Day : {dt.Day}");
            Console.WriteLine($"Month :{dt.Month}");
            Console.WriteLine($"Year : {dt.Year}");
            Console.WriteLine($"Hour : {dt.Hour}");
            Console.WriteLine($"Minute : {dt.Minute}");
            Console.WriteLine($"Second : {dt.Second}");
            Console.WriteLine($"MilliSecond :{dt.Millisecond} \n");

            // AddDays

            DateTime tendaysFromNow = dt.AddDays(10);
            Console.WriteLine($"Ten days added : {tendaysFromNow}");

            // AddHours

            DateTime tenDaysAndTwentyHoursFromNow = dt.AddHours(20).AddDays(10);
            Console.WriteLine($"Ten days and twenty hours added : {tenDaysAndTwentyHoursFromNow} \n");

            // Subtract Hours

            DateTime threeHoursAgo = dt.AddHours(-3);
            Console.WriteLine($"Three hours subtracted : {threeHoursAgo} \n");

            // Formatting date and time

            Console.WriteLine(dt.ToString("MM-dd-yyyy hh:mm:ss"));
            Console.WriteLine(dt.ToString("dd-MM-yyyy hh:mm:ss"));
            Console.WriteLine(dt.ToString("dd/MM/yyyy hh:mm:ss"));
            Console.WriteLine(dt.ToString("MM/dd/yyyy") + "\n");

            // Constructing Date and Time 

            DateTime myDt = new DateTime(2024, 10, 07, 10, 50, 49);
            Console.WriteLine($"Constructed datetime : {myDt}");

        }
    }
}
