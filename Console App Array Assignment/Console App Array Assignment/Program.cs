using System;
using System.Collections.Generic;

namespace ArrayAndListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------
            // PART 1: Array of Strings
            // -----------------------------

            // Create a one-dimensional array of strings
            string[] stringArray = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            // Ask the user to select an index
            Console.WriteLine("Select an index of the string array (0 to " + (stringArray.Length - 1) + "):");

            // Read user input
            string stringIndexInput = Console.ReadLine();

            // Try converting input to an integer
            if (int.TryParse(stringIndexInput, out int stringIndex))
            {
                // Check if the index is within range
                if (stringIndex >= 0 && stringIndex < stringArray.Length)
                {
                    // Display the string at that index
                    Console.WriteLine("The value at index " + stringIndex + " is: " + stringArray[stringIndex]);
                }
                else
                {
                    // Handle invalid index
                    Console.WriteLine("That index does not exist in the string array.");
                }
            }
            else
            {
                // Handle invalid (non-numeric) input
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Console.WriteLine(); // Blank line for readability

            // -----------------------------
            // PART 2: Array of Integers
            // -----------------------------

            // Create a one-dimensional array of integers
            int[] intArray = { 10, 20, 30, 40, 50 };

            // Ask the user to select an index
            Console.WriteLine("Select an index of the integer array (0 to " + (intArray.Length - 1) + "):");

            // Read user input
            string intIndexInput = Console.ReadLine();

            // Try converting input to an integer
            if (int.TryParse(intIndexInput, out int intIndex))
            {
                // Check if the index is within range
                if (intIndex >= 0 && intIndex < intArray.Length)
                {
                    // Display the integer at that index
                    Console.WriteLine("The value at index " + intIndex + " is: " + intArray[intIndex]);
                }
                else
                {
                    // Handle invalid index
                    Console.WriteLine("That index does not exist in the integer array.");
                }
            }
            else
            {
                // Handle invalid (non-numeric) input
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Console.WriteLine(); // Blank line for readability

            // -----------------------------
            // PART 3: List of Strings
            // -----------------------------

            // Create a list of strings
            List<string> stringList = new List<string>() { "Dog", "Cat", "Bird", "Fish", "Horse" };

            // Ask the user to select an index
            Console.WriteLine("Select an index of the string list (0 to " + (stringList.Count - 1) + "):");

            // Read user input
            string listIndexInput = Console.ReadLine();

            // Try converting input to an integer
            if (int.TryParse(listIndexInput, out int listIndex))
            {
                // Check if the index is within range
                if (listIndex >= 0 && listIndex < stringList.Count)
                {
                    // Display the string at that index
                    Console.WriteLine("The value at index " + listIndex + " is: " + stringList[listIndex]);
                }
                else
                {
                    // Handle invalid index
                    Console.WriteLine("That index does not exist in the string list.");
                }
            }
            else
            {
                // Handle invalid (non-numeric) input
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            // Keep the console open until the user presses Enter
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
