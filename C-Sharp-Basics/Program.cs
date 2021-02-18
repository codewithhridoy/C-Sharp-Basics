using System;
using System.Linq;

namespace C_Sharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {

            // Simple Calculator using Methods
            
            while(true)
            {
                Console.WriteLine("Type 'a/A' to Add:");
                Console.WriteLine("Type 's/S' to Subtract:");
                Console.WriteLine("Type 'm/M' to Multiply:");
                Console.WriteLine("Type 'd/D' to Devide:");
                Console.WriteLine("Type 'r/R' for Remainder:");
                Console.WriteLine("Type 'e/E' for Exit:");
            
                string checkInput = Console.ReadLine();

                if (checkInput == "e" || checkInput == "E")
                {
                    break;
                }

                else if (checkInput == "a" || checkInput == "A")
                {
                    Console.Write("Enter your First Number : ");
                    int firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter your Second Number : ");
                    int secondNumber = Convert.ToInt32(Console.ReadLine());

                    int sum = Add(firstNumber, secondNumber);
                    Console.WriteLine("Sum = " + sum);
                    
                    Console.WriteLine("Type 'y/Y' to Continue.");

                    string continueCheck = Console.ReadLine();

                    if (checkInput == "y" || checkInput == "Y")
                    {
                        continue;
                    }

                }

                else if (checkInput == "s" || checkInput == "S")
                {
                    Console.Write("Enter your First Number : ");
                    int firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter your Second Number : ");
                    int secondNumber = Convert.ToInt32(Console.ReadLine());

                    int subResult = Subtract(firstNumber, secondNumber);
                    Console.WriteLine("Subtract = " + subResult);
                    
                    Console.WriteLine("Type 'y/Y' to Continue.");

                    string continueCheck = Console.ReadLine();

                    if (checkInput == "y" || checkInput == "Y")
                    {
                        continue;
                    }

                }

                else if (checkInput == "m" || checkInput == "M")
                {
                    Console.Write("Enter your First Number : ");
                    int firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter your Second Number : ");
                    int secondNumber = Convert.ToInt32(Console.ReadLine());

                    int mulResult = Multiply(firstNumber, secondNumber);
                    Console.WriteLine("Multiply = " + mulResult);
                    
                    Console.WriteLine("Type 'y/Y' to Continue.");

                    string continueCheck = Console.ReadLine();

                    if (checkInput == "y" || checkInput == "Y")
                    {
                        continue;
                    }

                }

                else if (checkInput == "d" || checkInput == "D")
                {
                    Console.Write("Enter your First Number : ");
                    int firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter your Second Number : ");
                    int secondNumber = Convert.ToInt32(Console.ReadLine());

                    int divResult = Divide(firstNumber, secondNumber);
                    Console.WriteLine("Divide = " + divResult);
                    
                    Console.WriteLine("Type 'y/Y' to Continue.");

                    string continueCheck = Console.ReadLine();

                    if (checkInput == "y" || checkInput == "Y")
                    {
                        continue;
                    }
                }

                else if (checkInput == "r" || checkInput == "R")
                {
                    Console.Write("Enter your First Number : ");
                    int firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter your Second Number : ");
                    int secondNumber = Convert.ToInt32(Console.ReadLine());

                    int remResult = Remainder(firstNumber, secondNumber);
                    Console.WriteLine("Remainder = " + remResult);
                    
                    Console.WriteLine("Type 'y/Y' to Continue.");

                    string continueCheck = Console.ReadLine();

                    if (checkInput == "y" || checkInput == "Y")
                    {
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry Wrong Keyword. Try agian!");
                    continue;
                }

            }


        }
        static int Add(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }

        static int Subtract(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;
            return result;
        }

        static int Multiply(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            return result;
        }

        static int Divide(int firstNumber, int secondNumber)
        {
            int result = firstNumber / secondNumber;
            return result;
        }

        static int Remainder(int firstNumber, int secondNumber)
        {
            int result = firstNumber % secondNumber;
            return result;
        }

    }
}
