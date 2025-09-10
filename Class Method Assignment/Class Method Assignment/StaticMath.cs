using System;

namespace ClassMethodAssignment
{
    // Static class: cannot be instantiated, used directly via class name
    public static class StaticMath
    {
        // Static method: multiplies two numbers
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
