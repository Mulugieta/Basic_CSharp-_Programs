using System;

namespace AbstractClassAssignment
{
    // Program class contains the Main method, which is the entry point of the application
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Employee object using an object initializer
            Employee employee = new Employee
            {
                firstName = "Sample",
                lastName = "Student"
            };

            // Call the SayName method, which prints the employee's full name
            employee.SayName();

            // Prevent the console from closing immediately
            Console.ReadKey();
        }
    }
}
