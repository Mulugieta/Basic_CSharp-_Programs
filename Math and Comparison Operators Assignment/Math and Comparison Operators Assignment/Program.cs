using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            // Print program title
            Console.WriteLine("Anonymous Income Comparison Program\n");

            // --- PERSON 1 INPUT ---
            Console.WriteLine("Person 1");
            Console.Write("Hourly Rate? ");
            decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine()); // store hourly rate as decimal for money accuracy
            Console.Write("Hours worked per week? ");
            int hoursPerWeek1 = Convert.ToInt32(Console.ReadLine());    // hours per week as int

            // --- PERSON 2 INPUT ---
            Console.WriteLine("\nPerson 2");
            Console.Write("Hourly Rate? ");
            decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Hours worked per week? ");
            int hoursPerWeek2 = Convert.ToInt32(Console.ReadLine());

            // --- CALCULATE ANNUAL SALARIES ---
            // Annual salary = hourly rate × hours per week × 52 weeks
            decimal annualSalary1 = hourlyRate1 * hoursPerWeek1 * 52;
            decimal annualSalary2 = hourlyRate2 * hoursPerWeek2 * 52;

            // --- PRINT RESULTS ---
            Console.WriteLine("\nAnnual salary of Person 1:");
            Console.WriteLine(annualSalary1);

            Console.WriteLine("\nAnnual salary of Person 2:");
            Console.WriteLine(annualSalary2);

            // Compare salaries (true if Person 1 > Person 2, false otherwise)
            bool person1MakesMore = annualSalary1 > annualSalary2;

            Console.WriteLine("\nPerson 1 makes more money than Person 2");
            Console.WriteLine(person1MakesMore);

            // Keep console open until Enter is pressed
            Console.ReadLine();
        }
    }
}
