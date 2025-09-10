using System;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object and initialize properties
            Employee employee = new Employee();
            employee.FirstName = "Sample";  // Set FirstName property
            employee.LastName = "Student";  // Set LastName property
            employee.Id = 1;                 // Set Id property

            // Call the superclass method SayName() on the Employee object
            employee.SayName();

            Console.ReadLine(); // Keeps console open so we can see the output
        }
    }
}
