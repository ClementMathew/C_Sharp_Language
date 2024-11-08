using System;
using System.IO;
using Newtonsoft.Json;

namespace Json_Serialization
{
    [Serializable]

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Json_Serialization
    {
        public static void Main()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(path, "DotNet", "Json Serializable", "data.json");

            Directory.CreateDirectory(Path.Combine(path, "DotNet", "Json Serializable"));

            Person person = new Person() { Name = "Person 1", Age = 10 };

            // Serialize the Person object to JSON

            string jsonText = JsonConvert.SerializeObject(person, Newtonsoft.Json.Formatting.Indented);

            // Write the JSON to a file

            File.WriteAllText(filePath, jsonText);
            Console.WriteLine("Data has been written to JSON file.");

            // Read the JSON from the file

            string json = File.ReadAllText(filePath);

            // Deserialize the JSON back to a Person object

            Person deserializedPerson = JsonConvert.DeserializeObject<Person>(json);

            // Output the deserialized data

            Console.WriteLine($"Name: {deserializedPerson.Name}");
            Console.WriteLine($"Age: {deserializedPerson.Age}");
        }
    }
}
