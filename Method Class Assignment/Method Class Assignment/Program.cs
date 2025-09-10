using System;

namespace VoidMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class so we can use its methods
            MathOperations mathOps = new MathOperations();

            // Call the method using positional arguments
            // First number: math operation performed on this
            // Second number: printed to the console
            mathOps.DoMath(10, 5);

            // Call the method using named parameters
            // This makes it clear which value goes to which parameter
            mathOps.DoMath(firstNumber: 20, secondNumber: 8);

            // Keeps the console open so the user can see the output
            Console.ReadLine();
        }
    }
}
