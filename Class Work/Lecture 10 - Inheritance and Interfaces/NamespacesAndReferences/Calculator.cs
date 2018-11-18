using System;

namespace Progress.MyIncredibleProduct.Calculus
{
    public class Calculator
    {
        public static readonly string Version = "2.9.213";

        // static method
        public static int Add(int a, int b)
        {
            // invalid call (static to instance method)
            // Substract(2, 2);

            return a + b;
        }

        // instance method
        public int Substract(int a, int b)
        {
            // valid call (instance to static method)
            // Add(2, 2);

            return a - b;
        }
    }
}
