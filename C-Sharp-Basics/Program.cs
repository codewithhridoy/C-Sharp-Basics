using System;

namespace C_Sharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hridoy";
            string str2 = "Ahmed";

            bool isEqual = str.Equals(str2, StringComparison.OrdinalIgnoreCase);

            Console.WriteLine(isEqual); // False

            string formattedString = string.Format("{0} {1} from Bangladesh", str, str2);

            Console.WriteLine(formattedString);





        }
    }
}
