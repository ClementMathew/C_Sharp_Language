using System;
using System.Collections.Generic;

namespace Doctor_Appointment_Management_System
{
    internal class Doctor_Appointment_Management_System
    {
        static void Main(string[] args)
        {
            AppointmentManager appointmentManager = new AppointmentManager();

            Console.WriteLine("Welcome to the Doctor Appointment System\n");

            while (true)
            {
                Console.WriteLine("\n1. Book Appointment");
                Console.WriteLine("2. View Appointments");
                Console.WriteLine("3. Exit");

                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Patient Name: ");
                        string patientName = Console.ReadLine();

                        Console.Write("Enter Appointment Start Time (dd/MM/yyyy hh:mm tt): ");
                        DateTime startTime;

                        while (!DateTime.TryParse(Console.ReadLine(), out startTime))
                        {
                            Console.Write("Invalid format. Enter Appointment Start Time (dd/MM/yyyy hh:mm tt): ");
                        }

                        Console.Write("Enter Appointment End Time (dd/MM/yyyy hh:mm tt): ");
                        DateTime endTime;

                        while (!DateTime.TryParse(Console.ReadLine(), out endTime))
                        {
                            Console.Write("Invalid format. Enter Appointment End Time (dd/MM/yyyy hh:mm tt): ");
                        }

                        appointmentManager.BookAppointment(patientName, startTime, endTime);
                        break;

                    case "2":
                        Console.WriteLine("\nScheduled Appointments:");
                        List<Appointment> appointments = appointmentManager.GetAppointments();

                        if (appointments.Count > 0)
                        {
                            foreach (Appointment appointment in appointments)
                            {
                                Console.WriteLine(appointment);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No appointments scheduled.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Thank you for using the Doctor Appointment System!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
