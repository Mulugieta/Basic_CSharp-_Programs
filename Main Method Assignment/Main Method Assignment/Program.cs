using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the first method with an integer
            int intResult = mathOps.DoMath(10); // 10 + 5
            Console.WriteLine("Integer method result: " + intResult);

            // Call the second method with a decimal
            int decimalResult = mathOps.DoMath(12.5m); // 12.5 * 2
            Console.WriteLine("Decimal method result: " + decimalResult);

            // Call the third method with a string that converts to an integer
            int stringResult = mathOps.DoMath("15"); // 15 - 3
            Console.WriteLine("String method result: " + stringResult);

            Console.ReadLine(); // Keep the console open
        }
    }
}
