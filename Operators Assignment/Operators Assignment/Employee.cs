using System;

namespace OperatorOverloadingAssignment
{
    // Employee class with properties and operator overloading
    public class Employee
    {
        // Unique identifier for each Employee
        public int Id { get; set; }

        // Employee's first name
        public string FirstName { get; set; }

        // Employee's last name
        public string LastName { get; set; }

        // Overload the == operator to compare Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both objects are null, they are considered equal
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If one is null and the other is not, they are not equal
            if (emp1 is null || emp2 is null)
                return false;

            // Compare employees by their Id property
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator (must be paired with ==)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Return the opposite of the == operator
            return !(emp1 == emp2);
        }

        // Best practice: override Equals() for consistency with ==
        public override bool Equals(object obj)
        {
            // Check if the object is an Employee and compare by Id
            if (obj is Employee otherEmployee)
                return this.Id == otherEmployee.Id;

            return false;
        }

        // Best practice: override GetHashCode() whenever Equals is overridden
        public override int GetHashCode()
        {
            // Use Id as the hash code since equality is based on Id
            return Id.GetHashCode();
        }
    }
}
