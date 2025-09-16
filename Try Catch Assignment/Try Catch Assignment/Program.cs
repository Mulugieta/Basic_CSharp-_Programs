using System; // Provides basic classes like Console for input/output

class Program
{
    static void Main(string[] args)
    {
        // Print a welcome message to the user
        Console.WriteLine("Welcome! Let's find out the year you were born.");

        try
        {
            // Ask the user for their age
            Console.Write("Please enter your age: ");
            string input = Console.ReadLine(); // Read the user input as a string

            // Convert the input to an integer
            int age = Convert.ToInt32(input);

            // Check for invalid ages: zero or negative numbers
            if (age <= 0)
            {
                Console.WriteLine("Error: Age cannot be zero or negative. Please try again.");
            }
            else
            {
                // Calculate the birth year using the current year
                int currentYear = DateTime.Now.Year;
                int birthYear = currentYear - age;

                // Display the birth year to the user
                Console.WriteLine("You were born in the year: " + birthYear);
            }
        }
        catch (FormatException) // Handles cases where the user enters non-numeric input
        {
            Console.WriteLine("Error: Please enter a valid number for your age.");
        }
        catch (Exception ex) // Handles any other unexpected exceptions
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
