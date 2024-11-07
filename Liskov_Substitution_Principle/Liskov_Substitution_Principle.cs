using System;

namespace Liskov_Substitution_Principle
{
    // Base class

    public class Bird
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Chirp!");
        }
    }

    // Interface for flying behavior

    public interface IFlyable
    {
        void Fly();
    }

    // Class for flying birds

    public class Sparrow : Bird, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I can fly!");
        }
    }

    // Class for non-flying birds

    public class Penguin : Bird
    {
        // No Fly method needed, as penguins don't fly
    }

    // BirdWatcher works only with flying birds

    public class BirdWatcher
    {
        public void WatchBirdFly(IFlyable bird)
        {
            bird.Fly();
        }
    }
    internal class Liskov_Substitution_Principle
    {
        static void Main(string[] args)
        {
            Bird sparrow = new Sparrow();
            Bird penguin = new Penguin();

            BirdWatcher watcher = new BirdWatcher();

            // Pass only flying birds

            watcher.WatchBirdFly((IFlyable)sparrow);

            // watcher.WatchBirdFly((IFlyable)penguin); // Compilation error, penguin cannot fly
        }
    }
}

