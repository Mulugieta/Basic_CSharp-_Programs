using System; // Provides basic classes like Console for input/output

class Program
{
    // Create a const variable - this value cannot be changed anywhere in the code
    const string AppTitle = "Constructor Assignment Demo";

    static void Main(string[] args)
    {
        // Print the title of the application using the const variable
        Console.WriteLine("Welcome to " + AppTitle);

        // Create a variable using 'var' - the compiler automatically detects the type based on the assigned value
        var number = 25; // The compiler treats this as an int because we assigned an integer value

        // Print the variable to show it works correctly
        Console.WriteLine("The value stored in 'number' is: " + number);

        // Create an instance of the Person class to demonstrate constructor chaining
        Person person1 = new Person("Alice"); // Calls the constructor that takes only the name
    }
}

// Class to demonstrate constructor chaining
class Person
{
    private string name;
    private int age;

    // First constructor: takes only a name, then chains to the second constructor using 'this'
    public Person(string name) : this(name, 30) // Default age is 30 if not provided
    {
        // No code here; chaining passes control to the second constructor below
    }

    // Second constructor: takes both name and age
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;

        // Print values to confirm that the constructor was executed
        Console.WriteLine($"Person created: Name = {this.name}, Age = {this.age}");
    }
}
