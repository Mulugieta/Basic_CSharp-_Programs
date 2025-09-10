using System;

namespace AbstractClassAssignment
{
    // Abstract class Person - serves as a base class
    public abstract class Person
    {
        // Property to store first name
        public string firstName { get; set; }

        // Property to store last name
        public string lastName { get; set; }

        // Abstract method that must be implemented by derived classes
        public abstract void SayName();
    }
}
