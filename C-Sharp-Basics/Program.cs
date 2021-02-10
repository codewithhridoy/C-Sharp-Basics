using System;

namespace C_Sharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strings

            string fname = "Hridoy";
            string lname = "Ahmed";
            Console.WriteLine(fname.Length); // Length

            // Lower and Uper Case
            Console.WriteLine(fname.ToLower());
            Console.WriteLine(fname.ToUpper());

            // Concat
            string name = string.Concat(fname, lname);
            Console.WriteLine(name);

            // Access Strings
            Console.WriteLine(name[0]);

            // Indexing
            Console.WriteLine(name.IndexOf("i"));

            // Substring
            Console.WriteLine(name.Substring(2, 3)); // starts from, ends where from start

            // Empty String
            string emptyString = string.Empty;

            Console.WriteLine(emptyString);

            // Replace
            string replacedString = name.Replace("Hridoy", "Hridoy ");
            Console.WriteLine(replacedString);

        }
    }
}
