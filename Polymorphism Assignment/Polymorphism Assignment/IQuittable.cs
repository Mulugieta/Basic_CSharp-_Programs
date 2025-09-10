using System;

namespace AbstractClassAssignment
{
    // Define an interface called IQuittable
    // Interfaces specify a contract: any class implementing this must define the methods
    public interface IQuittable
    {
        // Method signature for Quit()
        // Any implementing class must provide its own behavior for this method
        void Quit();
    }
}
