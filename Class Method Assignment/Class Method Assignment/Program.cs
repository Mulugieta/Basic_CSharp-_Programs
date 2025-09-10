using System;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class to use its methods
            MathOperations mathOps = new MathOperations();

            // Ask the user for a number
            Console.WriteLine("Enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Call the void method that divides the number by 2
            mathOps.DivideByTwo(userNumber);

            // Use a method with output parameters
            int sum;
            mathOps.AddNumbers(5, 10, out sum); // sum will be set inside the method
            Console.WriteLine("Sum using output parameter: " + sum);

            // Demonstrate method overloading
            int squareResult = mathOps.DoMath(5);           // Single integer parameter
            int sumResult = mathOps.DoMath(5, 10);          // Two integer parameters
            Console.WriteLine("Square Result: " + squareResult);
            Console.WriteLine("Sum Result: " + sumResult);

            // Using the static class without creating an instance
            int product = StaticMath.Multiply(5, 3);
            Console.WriteLine("Static Class Multiplication Result: " + product);

            Console.ReadLine(); // Keeps console open
        }
    }
}
