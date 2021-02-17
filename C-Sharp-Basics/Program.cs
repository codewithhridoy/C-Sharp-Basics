using System;

// Use System.Linq
using System.Linq;

namespace C_Sharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            string [] cars = new string[3];
            cars[0] = "Volvo";
            cars[1] = "Tesla";
            cars[2] = "Ford";

            Console.WriteLine(cars[2]); //Ford

            int [] myNum = {100, 20, 300, 40};

            Console.WriteLine(myNum[3]);

            // Length
            Console.WriteLine(myNum.Length);

            // Loop Through Array
            for (int i = 0; i < myNum.Length; i++)
            {
                Console.WriteLine(myNum[i]);
            }

            // Foreach
            foreach(string i in cars)
            {
                Console.WriteLine(i);
            }


            // Sort Arrays
            Array.Sort(myNum); // 20, 40, 100, 300
            Console.WriteLine(myNum[0]);

            for (int i=0; i<myNum.Length; i++)
            {
                Console.WriteLine(myNum[i]);
            }

            // Max, Min, Sum
            Console.WriteLine(myNum.Max());
            Console.WriteLine(myNum.Min());
            Console.WriteLine(myNum.Sum());

        }
    }
}
