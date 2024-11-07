using System;
using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using log4net.Repository;

namespace Console_Logging
{
    internal class Console_Logging
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Console_Logging));
        static void Main(string[] args)
        {
            ConfigureLogging();

            try
            {
                Console.Write("Enter num1: ");
                int i = int.Parse(Console.ReadLine());

                Console.Write("Enter num2: ");
                int j = int.Parse(Console.ReadLine());

                int sum = i + j;
                Console.WriteLine("Sum: " + sum);
            }
            catch (Exception e)
            {
                log.Error("An error occurred: " + e.Message);
            }
        }

        private static void ConfigureLogging()
        {
            // Get the repository for the current logger configuration

            ILoggerRepository repository = LogManager.GetRepository();

            // Define layout pattern

            PatternLayout layout = new PatternLayout
            {
                ConversionPattern = "%date [%thread] %-5level %logger - %message%newline"
            };
            layout.ActivateOptions();

            // Set up a console appender

            ConsoleAppender consoleAppender = new ConsoleAppender
            {
                Layout = layout,
                Threshold = Level.Info
            };
            consoleAppender.ActivateOptions();

            // Basic configuration for both appenders

            BasicConfigurator.Configure(repository, consoleAppender);
        }
    }
}
