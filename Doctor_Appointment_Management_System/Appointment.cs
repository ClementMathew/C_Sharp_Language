using System;

namespace Doctor_Appointment_Management_System
{
    public class Appointment
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string PatientName { get; set; }

        public Appointment(string patientName, DateTime startTime, DateTime endTime)
        {
            PatientName = patientName;
            StartTime = startTime;
            EndTime = endTime;
        }

        public override string ToString()
        {
            return $"{PatientName} - {StartTime:dd/MM/yyyy hh:mm tt} to {EndTime:hh:mm tt}";
        }
    }
}
