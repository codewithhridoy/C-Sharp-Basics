using System;

namespace C_Sharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            string someText = "Here is some text";
            int num = 10;
            double num2 = 20.2;
            bool isOdd = true;
            
            Console.WriteLine("Enter Your Number: \n");  
            string name = Console.ReadLine();
            var anything = 50;

            Console.WriteLine(someText);
            Console.WriteLine(num);
            Console.WriteLine(num2);
            Console.WriteLine(isOdd);
            Console.WriteLine("Hello " + name);
            Console.WriteLine(anything);

        }
    }
}
