using System;
using System.Collections.Generic;

namespace Patient_Management_System
{
    internal class Patient_Management_System
    {
        static Dictionary<int, Dictionary<string, string>> Patients = new Dictionary<int, Dictionary<string, string>>();

        static int patient_id = 0;

        static void AddPatient()
        {
            Console.WriteLine("Enter the name : ");
            string patient_name = Console.ReadLine();

            Console.WriteLine("Enter the age : ");
            string patient_age = Console.ReadLine();

            Console.WriteLine("Enter the symptoms by comma separated : ");
            string symptoms = Console.ReadLine();

            Dictionary<string, string> Temp = new Dictionary<string, string>();

            Temp.Add("patient_name", patient_name);
            Temp.Add("patient_age", patient_age);
            Temp.Add("symptoms", symptoms);

            Patients.Add(patient_id, Temp);
            patient_id++;
        }

        static void GetPatient()
        {
            Console.WriteLine("Enter the patient id : ");
            int id = int.Parse(Console.ReadLine());

            foreach (KeyValuePair<int, Dictionary<string, string>> Patient in Patients)
            {
                if (Patient.Key == id)
                {
                    foreach (KeyValuePair<string, string> item in Patient.Value)
                    {
                        Console.WriteLine($"{item.Key} : {item.Value}");
                    }
                }
            }
        }

        static void GetPatientBySymptom()
        {
            Console.WriteLine("Enter the symptom : ");
            string symptom = Console.ReadLine();

            bool found = false;

            foreach (KeyValuePair<int, Dictionary<string, string>> Patient in Patients)
            {
                if (Patient.Value["symptoms"].Contains(symptom))
                {
                    Console.WriteLine();
                    foreach (KeyValuePair<string, string> item in Patient.Value)
                    {
                        Console.WriteLine($"{item.Key} : {item.Value}");
                    }
                    Console.WriteLine();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No patients found with the given symptom.");
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\n1 for AddPatient \n2 for GetPatient \n3 for GetPatientBySymptom \n\nEnter the value : ");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (n)
                {
                    case 1:
                        AddPatient();
                        break;
                    case 2:
                        GetPatient();
                        break;
                    case 3:
                        GetPatientBySymptom();
                        break;

                    default:
                        Console.WriteLine("No match");
                        break;
                }
            }
        }
    }
}
