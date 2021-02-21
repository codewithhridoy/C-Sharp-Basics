using System;
using System.Linq;

namespace C_Sharp_Basics
{
    // Encapsulation
    class Person
    {   
        private string name;
        // property
        public string Name
        {
            get {return name;}
            set {name =  value;}
        }
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
