using System;

namespace MathOperations
{
    class Program
    {
        static void Main()
        {
            // --- MULTIPLY BY 50 ---
            Console.Write("Enter a number to multiply by 50: ");
            long input1 = Convert.ToInt64(Console.ReadLine());   // store input as long for big numbers
            long result1 = input1 * 50;                         // multiply by 50
            Console.WriteLine("Result: " + result1);            // print result to console

            // --- ADD 25 ---
            Console.Write("\nEnter a number to add 25: ");
            long input2 = Convert.ToInt64(Console.ReadLine());  // read input as long
            long result2 = input2 + 25;                         // add 25
            Console.WriteLine("Result: " + result2);            // print result

            // --- DIVIDE BY 12.5 ---
            Console.Write("\nEnter a number to divide by 12.5: ");
            double input3 = Convert.ToDouble(Console.ReadLine()); // use double since we’re dividing by a decimal
            double result3 = input3 / 12.5;                       // divide by 12.5
            Console.WriteLine("Result: " + result3);              // print result

            // --- CHECK IF GREATER THAN 50 ---
            Console.Write("\nEnter a number to check if it is greater than 50: ");
            long input4 = Convert.ToInt64(Console.ReadLine());    // read input
            bool isGreater = input4 > 50;                         // compare with 50, returns true/false
            Console.WriteLine("Is greater than 50? " + isGreater);// print result

            // --- DIVIDE BY 7 (REMAINDER) ---
            Console.Write("\nEnter a number to divide by 7 and see the remainder: ");
            long input5 = Convert.ToInt64(Console.ReadLine());    // read input
            long remainder = input5 % 7;                          // modulus operator (%) gives remainder
            Console.WriteLine("Remainder: " + remainder);         // print remainder

            // Pause so console window stays open until Enter is pressed
            Console.ReadLine();
        }
    }
}
