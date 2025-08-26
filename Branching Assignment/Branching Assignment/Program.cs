using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user to enter the package weight
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine()); // Read user input and convert to double

            // Check if the weight is greater than 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Exit the program if the package is too heavy
            }

            // Prompt user to enter the package width
            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());

            // Prompt user to enter the package height
            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());

            // Prompt user to enter the package length
            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());

            // Check if the sum of the dimensions is greater than 50
            if ((width + height + length) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Exit the program if the package is too big
            }

            // Calculate the shipping quote
            double quote = (width * height * length * weight) / 100;

            // Display the quote formatted as a dollar amount
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:0.00}");
            Console.WriteLine("Thank you!");
        }
    }
}
