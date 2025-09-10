using System;

namespace AbstractClassAssignment
{
    // Employee inherits from Person (abstract class)
    // and implements IQuittable (interface)
    public class Employee : Person, IQuittable
    {
        // Implementation of the SayName() method from Person
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        // Implementation of Quit() from IQuittable
        public void Quit()
        {
            Console.WriteLine(firstName + " " + lastName + " has quit the job.");
        }
    }
}
