using System;

namespace StaticExamples
{
    public static class StaticCalculator
    {
        public static string Version
        {
            get
            {
                return "2.9.213";
            }
        }

        public static readonly string CurrentDirectory;

        // static constructor (called only once per application program execution)
        static StaticCalculator()
        {
            CurrentDirectory = Environment.CurrentDirectory;
        }

        // static method
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // instance method
        public static int Substract(int a, int b)
        {
            return a - b;
        }
    }
}
