using System;
using System.Linq;

namespace C_Sharp_Basics
{
    class Person
    {
        // property
        public string Name
        { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person aPerson = new Person();
            aPerson.Name = "Hridoy";

            Console.WriteLine(aPerson.Name);

        }
            
    }
}
