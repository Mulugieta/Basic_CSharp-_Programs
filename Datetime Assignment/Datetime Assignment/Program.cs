using System; // Import the System namespace for basic functionalities like Console and DateTime

class Program
{
    static void Main()
    {
        // Print the current date and time to the console
        Console.WriteLine("Current date and time: " + DateTime.Now);

        // Ask the user for a number representing hours to add
        Console.Write("Enter the number of hours to add: ");
        string input = Console.ReadLine(); // Read user input as a string

        // Convert the user input from string to double
        double hours;
        if (double.TryParse(input, out hours)) // TryParse avoids crashes if the input is invalid
        {
            // Calculate the future time by adding the entered hours
            DateTime futureTime = DateTime.Now.AddHours(hours);

            // Print the future time to the console
            Console.WriteLine("The exact time in " + hours + " hours will be: " + futureTime);
        }
        else
        {
            // Show an error message if the input was not a valid number
            Console.WriteLine("Invalid input. Please enter a numeric value for hours.");
        }
    }
}
