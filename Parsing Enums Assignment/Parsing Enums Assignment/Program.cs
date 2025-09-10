using System;

namespace ParsingEnumsAssignment
{
    // Define an enum for the days of the week
    // Enums are strongly-typed constants, useful for representing fixed sets of values
    public enum DaysOfTheWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the current day of the week
            Console.WriteLine("Please enter the current day of the week:");

            // Read user input from the console
            string userInput = Console.ReadLine();

            try
            {
                // Try to parse the user's input into the DaysOfTheWeek enum
                // The 'true' parameter makes parsing case-insensitive (e.g., "monday" will work)
                DaysOfTheWeek currentDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput, true);

                // If parsing is successful, display the parsed enum value
                Console.WriteLine("You entered: " + currentDay);
            }
            catch
            {
                // If parsing fails (e.g., user types something invalid),
                // this block will execute
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Prevent console window from closing immediately
            Console.ReadKey();
        }
    }
}
