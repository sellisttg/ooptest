using System;

namespace OOP
{
    /// <summary>
    /// Task 0 Requirements: 
    ///     1) Make this project build and the main method run, do not modify the main method to accomplish this
    /// Task 0 Expected Output:
    ///     1) Two lines in the console:
    ///         Line 1: "Hello, I'm some sort of animal!"
    ///         Line 2: "Yes, I am a Mongoose!"
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            Mongoose mongoose = new Mongoose();
            mongoose.Greet();

            Console.ReadKey();
        }
    }

    public class Animal
    {
        public virtual void Greet()
        {
            Console.WriteLine("Hello, I'm some sort of animal!");
        }
    }

    public class Mongoose : Animal
    {
        public override void Greet()
        {
            base.Greet();
            Console.WriteLine("Yes, I am a Mongoose!");
        }
    }
}
