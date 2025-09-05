using System;
using System.Collections.Generic;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------
            // PART 1: One-dimensional array of strings
            // -------------------------------
            string[] stringArray = { "First", "Second", "Third", "Fourth" };

            Console.WriteLine("Enter text to append to each string in the array:");
            string userText = Console.ReadLine();

            // Append user input to each string in the array
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += " " + userText;
            }

            // Print updated array
            Console.WriteLine("\nUpdated Array:");
            foreach (string str in stringArray)
            {
                Console.WriteLine(str);
            }

            // -------------------------------
            // PART 2: Infinite loop example (fixed)
            // -------------------------------
            Console.WriteLine("\nCounting from 1 to 5:");
            int counter = 1;
            while (counter <= 5)  // Proper condition so it ends
            {
                Console.WriteLine(counter);
                counter++; // Increment → prevents infinite loop
            }

            // -------------------------------
            // PART 3: Loops with < and <= operators
            // -------------------------------
            Console.WriteLine("\nLoop using < operator:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"i = {i}");
            }

            Console.WriteLine("\nLoop using <= operator:");
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine($"i = {i}");
            }

            // -------------------------------
            // PART 4:
