using System;

namespace OOP1
{
    /// <summary>
    /// Task 1 Requirements: 
    ///     1) Make this project build and the main method run, do not modify the main method to accomplish this
    ///     2) Add a cat class which extends the animal class and describes itself by calling the FourLeggedAnimal describe and adding it's own description
    /// Task 1 Expected Output:
    ///     Two lines in the console:
    ///     Line 1: "OOP1.Dog class describe: Not much is known about this four legged animal!"
    ///     Line 2: "OOP1.Cat class describe: Not much is known about this four legged animal! In fact, all we know is that it's a cat!"
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //FourLeggedAnimal someAnimal = new FourLeggedAnimal();
            Dog dog = new Dog();
            Console.WriteLine($"{dog.GetType()} class describe: {dog.Describe()}");

            Cat cat = new Cat();
            Console.WriteLine($"{cat.GetType()} class describe: {cat.Describe()}");

            Console.ReadKey();
        }
    }

    abstract class FourLeggedAnimal
    {
        public virtual string Describe()
        {
            return "Not much is known about this four legged animal!";
        }
    }

    class Dog : FourLeggedAnimal
    {

    }
}
