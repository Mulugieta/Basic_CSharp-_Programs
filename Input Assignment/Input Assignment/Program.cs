using System;
using System.IO; // Required for working with files

class Program
{
    static void Main()
    {
        // Ask the user for a number and read the input
        Console.WriteLine("Please enter a number:");
        string userInput = Console.ReadLine(); // Reads user input as a string

        // Define the file path where the number will be saved
        string filePath = "numberLog.txt";

        // Write the user input to the text file
        File.WriteAllText(filePath, userInput);
        // 'File.WriteAllText' creates the file if it doesn't exist and writes the string to it.
        // If the file already exists, it will overwrite the contents.

        // Read the content back from the text file
        string fileContent = File.ReadAllText(filePath);
        // 'File.ReadAllText' opens the file, reads all the text, and returns it as a string.

        // Print the content back to the user
        Console.WriteLine("The number you entered (read from file) is: " + fileContent);
        // This shows the user what was read from the file.
    }
}
