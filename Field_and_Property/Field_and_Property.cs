using System;

namespace Field_and_Property
{
    class Fields_and_Propertys_Demo
    {
        public string Name;
        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0 && value < 50)
                {
                    age = value;
                }
            }
        }

        public int GetAge() => age;

        public void SetAge(int value)
        {
            if (value > 0 && value < 50)
            {
                age = value;
            }
        }
    }

    internal class Field_and_Property
    {
        static void Main(string[] args)
        {
            Fields_and_Propertys_Demo f = new Fields_and_Propertys_Demo();

            f.Name = "New Name";
            f.SetAge(250);

            Console.WriteLine(f.Name);
            Console.WriteLine(f.GetAge());

            Fields_and_Propertys_Demo f1 = new Fields_and_Propertys_Demo()
            {
                Name = "New New Name",
                Age = 20
            };

            Console.WriteLine(f1.Name);
            Console.WriteLine(f1.Age);
        }
    }
}
