using System;
using System.Linq;

namespace C_Sharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "Black";
            Ford.year = 1969;

            Console.WriteLine(Ford.model);
        }
            
    }
}
