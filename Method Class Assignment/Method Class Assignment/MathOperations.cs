using System;

namespace VoidMethodAssignment
{
    public class MathOperations
    {
        // Void method: takes two integers, performs a math operation on the first,
        // and displays the second integer
        public void DoMath(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer (e.g., multiply by 2)
            int result = firstNumber * 2;

            // Print the result of the math operation
            Console.WriteLine("First number after math operation: " + result);

            // Print the second number to the console
            Console.WriteLine("Second number is: " + secondNumber);
        }
    }
}
