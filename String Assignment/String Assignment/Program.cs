using System;
using System.Text; // Required to use StringBuilder

namespace StringManipulationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------- STRING CONCATENATION ----------------
            // Create three separate strings
            string part1 = "Hello";
            string part2 = "world";
            string part3 = "from C#!";

            // Concatenate the strings into one sentence
            string combinedString = part1 + " " + part2 + " " + part3;

            // Display the concatenated string
            Console.WriteLine("Concatenated String: " + combinedString);
            Console.WriteLine(); // Blank line for readability


            // ---------------- STRING TO UPPERCASE ----------------
            // Convert the concatenated string to uppercase
            string upperString = combinedString.ToUpper();

            // Display the uppercase version
            Console.WriteLine("Uppercase String: " + upperString);
            Console.WriteLine(); // Blank line for readability


            // ---------------- STRINGBUILDER EXAMPLE ----------------
            // Initialize a new StringBuilder to construct a paragraph
            StringBuilder paragraph = new StringBuilder();

            // Append sentences one at a time to build a paragraph
            paragraph.Append("This is the first sentence. ");
            paragraph.Append("Here comes the second sentence. ");
            paragraph.Append("Finally, this is the third sentence to complete the paragraph.");

            // Display the full paragraph
            Console.WriteLine("Paragraph built with StringBuilder:");
            Console.WriteLine(paragraph.ToString());

            // Wait for user input before closing console window
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
