using System;
using System.Collections.Generic; // Needed for List<T>

/// <summary>
/// Generic Employee class
/// T represents the type of items the Employee can hold in the "things" property
/// </summary>
class Employee<T>
{
    // Generic list property called "things" that can store items of type T
    public List<T> things { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an Employee object with string as the generic type
        Employee<string> employeeString = new Employee<string>
        {
            // Assign a list of strings to the 'things' property
            things = new List<string> { "Laptop", "Notebook", "Pen" }
        };

        // Create an Employee object with int as the generic type
        Employee<int> employeeInt = new Employee<int>
        {
            // Assign a list of integers to the 'things' property
            things = new List<int> { 101, 202, 303 }
        };

        // Print a header for clarity
        Console.WriteLine("Employee string things:");

        // Loop through each item in the string employee's 'things' list
        foreach (var item in employeeString.things)
        {
            // Print each item to the console
            Console.WriteLine(item);
        }

        // Print a header for clarity
        Console.WriteLine("\nEmployee int things:");

        // Loop through each item in the int employee's 'things' list
        foreach (var item in employeeInt.things)
        {
            // Print each item to the console
            Console.WriteLine(item);
        }

        // Pause the console so the output remains visible
        Console.ReadLine();
    }
}
