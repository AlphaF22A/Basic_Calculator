using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Basic_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            float result;
            string answer;
            bool CalculatorRunning = true;
            
            while (CalculatorRunning)
            {
                Console.WriteLine("Hi there, this is a basic calculator");
                Console.WriteLine("Enter your first number");
                num1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter your second number");
                num2 = float.Parse(Console.ReadLine());

                Console.WriteLine("Which math operation would you like to do?");
                Console.WriteLine("Enter 'a' for addition, 's' for subtraction, 'm' to multiply, and 'd' to divide (first divided by second)");

                answer = Console.ReadLine();

                if (answer == "a")
                {
                    result = num1 + num2;
                }
                else if (answer == "s")
                {
                    result = num1 - num2;
                }
                else if (answer == "m")
                {
                    result = num1 * num2;
                }
                else if (answer == "d")
                {
                    if (num2 == 0)
                    {
                        Console.WriteLine("Math Error!");
                        result = 0;
                        CalculatorRunning = false;
                    }
                    else
                    {
                        result = num1 / num2;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Error! Type in correct commands!");
                    result = 0;
                    CalculatorRunning = false;
                }

                Console.WriteLine("The result is "+ result);
                Console.WriteLine("Would you like to perform another calculation? Press Y to do so, any other button to cancel program");
                string loop = Console.ReadLine();
                if (loop == "Y")
                {
                    CalculatorRunning = true;
                }
                else
                {
                    CalculatorRunning = false;
                }    
            }
        }
    }
}
