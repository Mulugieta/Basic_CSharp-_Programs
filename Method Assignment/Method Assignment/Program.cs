using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Ask the user to enter the first number
            Console.WriteLine("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            // Ask the user to optionally enter the second number
            Console.WriteLine("Enter the second number (optional, press Enter to skip): ");
            string secondInput = Console.ReadLine();

            int result;

            // If the user provided a second number, use both numbers
            if (!string.IsNullOrEmpty(secondInput))
            {
                int secondNumber = Convert.ToInt32(secondInput);
                result = mathOps.DoMath(firstNumber, secondNumber);
            }
            else
            {
                // If no second number was given, just use the first number
                result = mathOps.DoMath(firstNumber);
            }

            // Display the result of the math operation
            Console.WriteLine("The result of the operation is: " + result);

            Console.ReadLine(); // Keeps the console open so user can see the result
        }
    }
}
