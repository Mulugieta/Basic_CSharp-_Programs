using System;

namespace AbstractClassAssignment
{
    // Employee class inherits from Person
    // Since Person is abstract, Employee must implement its abstract members
    public class Employee : Person
    {
        // Implementation of the SayName method from Person
        public override void SayName()
        {
            // Print full name to the console
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
