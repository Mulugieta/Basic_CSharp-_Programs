using System;

namespace StructAssignment
{
    // Define a struct called Number
    // Structs are value types (unlike classes, which are reference types)
    // They are useful for small, lightweight objects
    public struct Number
    {
        // Property called Amount of type decimal
        // 'decimal' is commonly used for financial and monetary values because of its precision
        public decimal Amount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of type Number
            Number num = new Number();

            // Assign a decimal value to the Amount property
            num.Amount = 123.45m; // 'm' suffix ensures the number is treated as a decimal literal

            // Print the value of Amount to the console
            Console.WriteLine("The amount is: " + num.Amount);

            // Prevent the console from closing immediately
            Console.ReadKey();
        }
    }
}
