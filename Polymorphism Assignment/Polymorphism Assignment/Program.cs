using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Employee object and assign names
            Employee employee = new Employee
            {
                firstName = "Sample",
                lastName = "Student"
            };

            // Call the SayName() method from Employee (inherited from Person)
            employee.SayName();

            // Use polymorphism: create an object of type IQuittable
            // and point it to an Employee object (since Employee implements IQuittable)
            IQuittable quittableEmployee = employee;

            // Call Quit() through the interface reference
            quittableEmployee.Quit();

            // Prevent the console window from closing immediately
            Console.ReadKey();
        }
    }
}
