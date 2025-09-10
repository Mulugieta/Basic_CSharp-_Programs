using System;
using System.Collections.Generic;
using System.Linq; // Needed to use LINQ extension methods like .Where()

namespace LambdaExpressionAssignment
{
    // Define the Employee class with three properties
    public class Employee
    {
        // Unique identifier for the employee
        public int Id { get; set; }

        // First name of the employee
        public string FirstName { get; set; }

        // Last name of the employee
        public string LastName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of employees (at least 10)
            // At least 2 employees should have the first name "Joe"
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 2, FirstName = "Mary", LastName = "Johnson" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Brown" },
                new Employee { Id = 4, FirstName = "Anna", LastName = "Taylor" },
                new Employee { Id = 5, FirstName = "James", LastName = "White" },
                new Employee { Id = 6, FirstName = "Emily", LastName = "Davis" },
                new Employee { Id = 7, FirstName = "Michael", LastName = "Wilson" },
                new Employee { Id = 8, FirstName = "Sarah", LastName = "Miller" },
                new Employee { Id = 9, FirstName = "David", LastName = "Anderson" },
                new Employee { Id = 10, FirstName = "Laura", LastName = "Clark" }
            };

            // ---------------------------------------------------
            // 1. Using foreach loop: filter employees with FirstName == "Joe"
            // ---------------------------------------------------
            List<Employee> joesForeach = new List<Employee>(); // create empty list for results
            foreach (Employee emp in employees) // loop through each employee
            {
                if (emp.FirstName == "Joe") // check if FirstName is "Joe"
                {
                    joesForeach.Add(emp); // if yes, add employee to the new list
                }
            }

            // Print the results
            Console.WriteLine("Employees named Joe (foreach loop):");
            foreach (var joe in joesForeach)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            Console.WriteLine(); // blank line for readability

            // ---------------------------------------------------
            // 2. Using lambda expression: filter employees with FirstName == "Joe"
            // ---------------------------------------------------
            // .Where() returns only employees where the condition matches
            List<Employee> joesLambda = employees.Where(emp => emp.FirstName == "Joe").ToList();

            // Print the results
            Console.WriteLine("Employees named Joe (lambda expression):");
            foreach (var joe in joesLambda)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            Console.WriteLine(); // blank line for readability

            // ---------------------------------------------------
            // 3. Using lambda expression: employees with Id greater than 5
            // ---------------------------------------------------
            // .Where() filters employees, then .ToList() makes a new list
            List<Employee> idGreaterThanFive = employees.Where(emp => emp.Id > 5).ToList();

            // Print the results
            Console.WriteLine("Employees with Id greater than 5 (lambda expression):");
            foreach (var emp in idGreaterThanFive)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.FirstName} {emp.LastName}");
            }

            // Prevent console window from closing immediately
            Console.ReadKey();
        }
    }
}
