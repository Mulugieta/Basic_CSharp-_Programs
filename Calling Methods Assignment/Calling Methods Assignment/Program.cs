using System;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class so we can use its methods
            MathOperations mathOps = new MathOperations();

            // Ask the user for a number
            Console.WriteLine("Enter an integer to perform math operations on:");
            int userNumber = Convert.ToInt32(Console.ReadLine()); // Convert input to integer

            // Call the first method: AddTen
            int addResult = mathOps.AddTen(userNumber);
            Console.WriteLine($"{userNumber} + 10 = {addResult}");

            // Call the second method: MultiplyByFive
            int multiplyResult = mathOps.MultiplyByFive(userNumber);
            Console.WriteLine($"{userNumber} * 5 = {multiplyResult}");

            // Call the third method: SubtractThree
            int subtractResult = mathOps.SubtractThree(userNumber);
            Console.WriteLine($"{userNumber} - 3 = {subtractResult}");

            // End program
            Console.WriteLine("\nAll methods executed. Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
