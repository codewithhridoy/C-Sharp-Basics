using System;

namespace C_Sharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Converted string to Int
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Number is = " + num);

            int num2 = 20;

            int add = num + num2;

            Console.WriteLine("Add = " + add);

        }
    }
}
