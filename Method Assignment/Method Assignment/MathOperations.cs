using System;

namespace MethodAssignment
{
    public class MathOperations
    {
        // Method with one required parameter and one optional parameter (default = 10)
        public int DoMath(int number1, int number2 = 10)
        {
            // Perform a simple math operation: add the two numbers
            return number1 + number2;
        }
    }
}
