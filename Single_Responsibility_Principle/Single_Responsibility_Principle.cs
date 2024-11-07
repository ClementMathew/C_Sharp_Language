using System;

namespace Single_Responsibility_Principle
{
    // Class responsible only for generating the report

    public class ReportGenerator
    {
        public string GenerateReport()
        {
            // Code to generate report

            return "Report Content";
        }
    }

    // Class responsible only for saving the report to a file

    public class ReportSaver
    {
        public void SaveToFile(string content)
        {
            // Code to save report to a file

            Console.WriteLine("Report saved to file.");
        }
    }

    // Class responsible only for sending the report via email

    public class ReportSender
    {
        public void SendEmail(string content)
        {
            // Code to send report via email

            Console.WriteLine("Report sent via email.");
        }
    }
    // Client code that uses the separate classes

    internal class Single_Responsibility_Principle
    {
        static void Main(string[] args)
        {
            // Create instances of each responsibility

            ReportGenerator generator = new ReportGenerator();
            ReportSaver saver = new ReportSaver();
            ReportSender sender = new ReportSender();

            // Generate the report

            string report = generator.GenerateReport();

            // Save and send the report using dedicated classes

            saver.SaveToFile(report);
            sender.SendEmail(report);
        }
    }
}

