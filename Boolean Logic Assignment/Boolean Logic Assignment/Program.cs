using System;

class Program
{
    static void Main()
    {
        // Print program header
        Console.WriteLine("Car Insurance Approval Program");

        // Ask applicant for age and convert input to integer
        Console.WriteLine("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine());

        // Ask applicant if they ever had a DUI and convert input to boolean
        Console.WriteLine("Have you ever had a DUI? (true/false)");
        bool hasDUI = Convert.ToBoolean(Console.ReadLine());

        // Ask applicant how many speeding tickets they have and convert input to integer
        Console.WriteLine("How many speeding tickets do you have?");
        int speedingTickets = Convert.ToInt32(Console.ReadLine());

        // Business rules for qualification:
        // 1. Age must be greater than 15
        // 2. Applicant must NOT have a DUI
        // 3. Applicant must NOT have more than 3 speeding tickets
        bool isQualified = (age > 15 && hasDUI == false && speedingTickets <= 3);

        // Print the result of qualification
        Console.WriteLine("Qualified?");
        Console.WriteLine(isQualified);

        // Keep console window open until user presses Enter
        Console.ReadLine();
    }
}
