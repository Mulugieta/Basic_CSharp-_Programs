using System;

namespace BooleanComparisonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------- WHILE LOOP EXAMPLE ----------------
            // Initialize a counter variable
            int count = 0;

            // The while loop runs as long as the condition is true
            // In this case: while count is less than 5
            while (count < 5)
            {
                Console.WriteLine("While Loop: Count is " + count);
                // Increment the counter to avoid infinite loop
                count++;
            }

            Console.WriteLine(); // Blank line for readability

            // ---------------- DO WHILE LOOP EXAMPLE ----------------
            // Reset counter variable
            int number = 0;

            // The do-while loop will always run at least once,
            // because the condition is checked AFTER the loop body
            do
            {
                Console.WriteLine("Do While Loop: Number is " + number);
                // Increment number
                number++;
            }
            while (number < 5); // Loop will continue as long as number is less than 5

            // Wait for user input before closing console window
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
