using System;

namespace Static_Class
{
    static class AppSettings
    {
        public static string Version => "1.0.0";

        public static string ProjectUrl => "https://github.com/";

        public static string AdminDashboardUrl => "https://www.myapp.com/admin";

        public static string DefaultSearchEngine { get; set; } = "Google";
    }

    internal class Static_Class
    {
        static void Main(string[] args)
        {
            // Cant create -> var settings = new AppSettings();

            Console.WriteLine(AppSettings.DefaultSearchEngine);

            AppSettings.DefaultSearchEngine = "Bing";

            Console.WriteLine(AppSettings.DefaultSearchEngine);

            // Cant change -> AppSettings.Version = "2.0.0";

            // All others are get only.
        }
    }
}
