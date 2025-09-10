using System;

namespace ClassMethodAssignment
{
    public class MathOperations
    {
        // Void method: divides number by 2 and prints the result
        public void DivideByTwo(int number)
        {
            int result = number / 2;
            Console.WriteLine("Number divided by 2: " + result);
        }

        // Method with output parameter: adds two numbers and assigns result to output variable
        public void AddNumbers(int a, int b, out int result)
        {
            result = a + b; // Sets the out parameter value
        }

        // Overloaded method: single parameter squares the number
        public int DoMath(int number)
        {
            return number * number;
        }

        // Overloaded method: two parameters adds the numbers
        public int DoMath(int a, int b)
        {
            return a + b;
        }
    }
}
