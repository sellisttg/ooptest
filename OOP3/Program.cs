using System;
using System.Collections.Generic;

namespace OOP3
{
    /// <summary>
    /// Task 3 Requirements: 
    ///     1) Make this project build and the main method run, do not modify the main method to accomplish this
    ///     2) Add a class called Lion that implements the IAnimal interface
    /// Task 3 Expected Output:
    ///     Three lines in the console:
    ///     Line 1: Hello, I'm a lion and my name is Adam
    ///     Line 2: Hello, I'm a lion and my name is Bob
    ///     Line 3: Hello, I'm a lion and my name is Fido
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<Lion> lions = new List<Lion>();
            lions.Add(new Lion("Fido"));
            lions.Add(new Lion("Bob"));
            lions.Add(new Lion("Adam"));
            lions.Sort();
            foreach (Lion lion in lions)
                Console.WriteLine(lion.Describe());
            Console.ReadKey();
        }
    }

    interface IAnimal
    {
        string Describe();

        string Name
        {
            get;
            set;
        }
    }

    class Lion : IAnimal
    {
        private string name;

        public Lion(string name)
        {
            this.Name = name;
        }

        public string Describe()
        {
            return "Hello, I'm a lion and my name is " + this.Name;
        }
       
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
