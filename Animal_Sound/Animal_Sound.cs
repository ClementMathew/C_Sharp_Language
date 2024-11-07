using System;

namespace Animal_Sound
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound.");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark!");
        }
    }
    internal class Animal_Sound
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myDog = new Dog();

            myAnimal.MakeSound();
            myDog.MakeSound();
        }
    }
}
