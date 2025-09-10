using System;
using System.Collections.Generic;

namespace StringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------
            // Step 1: Create a list of integers
            // -------------------------------
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

            // -------------------------------
            // Step 2: Ask the user for a number to divide each list item by
            // -------------------------------
            Console.WriteLine("Enter a number to divide each number in the list by:");

            // -------------------------------
            // Step 3: Use try/catch to handle bad input or division by zero
            // -------------------------------
            try
            {
                // Convert user input to integer
                int divisor = Convert.ToInt32(Console.ReadLine());

                // Loop through each number in the list
                foreach (int number in numbers)
                {
                    // Divide each number by user input and display result
                    int result = number / divisor;
                    Console.WriteLine($"{number} divided by {divisor} = {result}");
                }
            }
            catch (DivideByZeroException ex)
            {
                // Handle dividing by zero error
                Console.WriteLine("Error: You cannot divide by zero!");
                Console.WriteLine($"System Message: {ex.Message}");
            }
            catch (FormatException ex)
            {
                // Handle if user enters letters or symbols instead of a number
                Console.WriteLine("Error: Please enter a valid number.");
                Console.WriteLine($"System Message: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"System Message: {ex.Message}");
            }
            finally
            {
                // Code in 'finally' always runs
                Console.WriteLine("\nProgram has emerged from try/catch block and will continue execution.");
            }

            // -------------------------------
            // Step 4: End program
            // -------------------------------
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
