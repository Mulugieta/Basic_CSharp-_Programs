using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            // Print header information
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report.\n");

            // Ask for student's name and store it in a string variable
            Console.Write("What is your name? ");
            string studentName = Console.ReadLine();

            // Ask what course the student is on and store it in a string variable
            Console.Write("What course are you on? ");
            string courseName = Console.ReadLine();

            // Ask for page number and store it in an integer variable
            Console.Write("What page number? ");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            // Ask if the student needs help and store as a boolean (true/false)
            Console.Write("Do you need help with anything? Please answer \"true\" or \"false\": ");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());

            // Ask for positive experiences and store it in a string variable
            Console.Write("Were there any positive experiences you’d like to share? Please give specifics: ");
            string positiveExperience = Console.ReadLine();

            // Ask for other feedback and store it in a string variable
            Console.Write("Is there any other feedback you’d like to provide? Please be specific: ");
            string feedback = Console.ReadLine();

            // Ask how many hours the student studied and store as a double for precision
            Console.Write("How many hours did you study today? ");
            double hoursStudied = Convert.ToDouble(Console.ReadLine());

            // Print closing message
            Console.WriteLine("\nThank you for your answers. An Instructor will respond shortly. Have a great day!");

            // Optional: keep console open until user presses Enter
            Console.ReadLine();
        }
    }
}
