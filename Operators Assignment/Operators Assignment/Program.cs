using System;

namespace OperatorOverloadingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object
            Employee emp1 = new Employee
            {
                Id = 1,
                FirstName = "Alice",
                LastName = "Johnson"
            };

            // Create the second Employee object
            Employee emp2 = new Employee
            {
                Id = 1, // Same Id as emp1 to test equality
                FirstName = "Bob",
                LastName = "Smith"
            };

            // Compare emp1 and emp2 using the overloaded == operator
            if (emp1 == emp2)
            {
                Console.WriteLine("Employees are equal (same Id).");
            }
            else
            {
                Console.WriteLine("Employees are NOT equal (different Ids).");
            }

            // Compare emp1 and emp2 using the overloaded != operator
            if (emp1 != emp2)
            {
                Console.WriteLine("Employees are NOT equal (different Ids).");
            }
            else
            {
                Console.WriteLine("Employees are equal (same Id).");
            }

            // Prevent console window from closing immediately
            Console.ReadKey();
        }
    }
}
