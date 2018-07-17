using System;

namespace OOP2
{
    /// <summary>
    /// Task 2 Requirements: 
    ///     1) Make this project build and the main method run, do not modify the main method to accomplish this
    ///     2) Add a cow and elephant class to the project so that the output is as defined below
    /// Task 2 Expected Output:
    ///     1) Two lines in the console:
    ///         Line 1: "I'm a cow!"
    ///         Line 2: "I'm a elephant!"
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList animalList = new System.Collections.ArrayList();
            animalList.Add(new Cow());
            animalList.Add(new Elephant());
            foreach (FourLeggedAnimal animal in animalList)
                Console.WriteLine(animal.Describe());
            Console.ReadKey();
        }
    }

    abstract class FourLeggedAnimal
    {
        public abstract string Describe();
    }


    class Cow : FourLeggedAnimal
    {

        public override string Describe()
        {
            return "I'm a cow!";
        }
    }

    class Elephant : FourLeggedAnimal
    {
        public override string Describe()
        {
            return "I'm a elephant!";
        }
    }
}
