using System;

namespace AbstractClassAssignment
{
    // Define an abstract class named 'Person'
    // Abstract classes cannot be instantiated and serve as a base for other classes
    public abstract class Person
    {
        // Property to store the first name of a person
        public string firstName { get; set; }

        // Property to store the last name of a person
        public string lastName { get; set; }

        // Abstract method declaration (no body/implementation here)
        // Must be implemented by any non-abstract class that inherits Person
        public abstract void SayName();
    }
}
