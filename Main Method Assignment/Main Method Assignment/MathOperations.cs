using System;

namespace MainMethodAssignment
{
    public class MathOperations
    {
        // Method 1: Takes in an integer, adds 5, returns an integer
        public int DoMath(int number)
        {
            // Add 5 to the given integer
            return number + 5;
        }

        // Method 2: Takes in a decimal, multiplies by 2, returns an integer
        public int DoMath(decimal number)
        {
            // Multiply by 2 and convert result to integer
            return Convert.ToInt32(number * 2);
        }

        // Method 3: Takes in a string, converts to integer, subtracts 3, returns an integer
        public int DoMath(string numberString)
        {
            // Try to convert string to integer
            int number = Convert.ToInt32(numberString);

            // Subtract 3 from the converted integer
            return number - 3;
        }
    }
}
