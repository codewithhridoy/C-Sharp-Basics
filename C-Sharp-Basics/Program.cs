using System;

namespace C_Sharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // If Else if Else
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("The number is negative.");
            }

            else if(num > 0)
            {
                Console.WriteLine("The number is Positive.");
            }
            else
            {
                Console.WriteLine("The number is Zero.");
            }
        }
    }
}
