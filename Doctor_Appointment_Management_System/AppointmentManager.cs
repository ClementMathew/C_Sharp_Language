using System;
using System.Collections.Generic;

namespace Doctor_Appointment_Management_System
{
    public class AppointmentManager
    {
        private List<Appointment> appointments = new List<Appointment>();

        private const int WorkingHourStart = 9;
        private const int WorkingHourEnd = 17;

        public bool BookAppointment(string patientName, DateTime startTime, DateTime endTime)
        {
            if (!IsWithinWorkingHours(startTime, endTime))
            {
                Console.WriteLine("Appointment must be within working hours (9 AM to 5 PM).");
                return false;
            }

            if (!IsTimeSlotAvailable(startTime, endTime))
            {
                Console.WriteLine("The requested time slot is not available.");
                return false;
            }

            Appointment newAppointment = new Appointment(patientName, startTime, endTime);
            appointments.Add(newAppointment);

            Console.WriteLine($"Appointment booked successfully for {patientName}.");
            return true;
        }

        public List<Appointment> GetAppointments()
        {
            return appointments;
        }

        public bool IsTimeSlotAvailable(DateTime startTime, DateTime endTime)
        {
            foreach (Appointment appointment in appointments)
            {
                if (startTime < appointment.EndTime && endTime > appointment.StartTime)
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsWithinWorkingHours(DateTime startTime, DateTime endTime)
        {
            return startTime.Hour >= WorkingHourStart && endTime.Hour <= WorkingHourEnd;
        }
    }
}
