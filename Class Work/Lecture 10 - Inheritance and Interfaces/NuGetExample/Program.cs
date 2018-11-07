using System;
using MathNet.Numerics.Statistics;

namespace NuGetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] data = new double[] { 0.3, 2.3, 114342.32, 42.3, 2222, 232.2, 0.4 };
            Console.WriteLine($"Data = {string.Join(", ", data)}");

            // simple :) statistical function, that are not present in
            // System.Math, but we can use it from Math.NET library 
            // that is added through a NuGet package
            // note: knowing what these statistical function are, is not part of the course!!! 
            //
            // p.s. still as most of you are QAs, you should know :) 
                   
            Console.WriteLine($"Min = {Statistics.Minimum(data)}"); // similar as Math.Min
            Console.WriteLine($"Q1 = {Statistics.LowerQuartile(data)}"); // First Quartile 
            Console.WriteLine($"Median {Statistics.Median(data)}");
            Console.WriteLine($"Mean = {Statistics.Mean(data) }");
            Console.WriteLine($"Q3 = {Statistics.UpperQuartile(data)}"); // Third Quartile 
            Console.WriteLine($"Max = {Statistics.Maximum(data)}"); // similar as Math.Max

            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
