using System;

namespace FinancialForecasting
{
    class Program
    {
        static void Main(string[] args)
        {
        
            double initialValue = 1000.0;          
            double annualGrowthRate = 0.05;        
            int years = 5;                         

            
            double futureRecursive = CalculateFutureValueRecursive(initialValue, annualGrowthRate, years);
            Console.WriteLine($"[Recursive] Future value after {years} years: {futureRecursive:C2}");

            
            double futureIterative = CalculateFutureValueIterative(initialValue, annualGrowthRate, years);
            Console.WriteLine($"[Iterative] Future value after {years} years: {futureIterative:C2}");

            
            Console.WriteLine("\n--- Analysis ---");
            Console.WriteLine("Recursive Time Complexity: O(n)");
            Console.WriteLine("Recursive Space Complexity: O(n) due to call stack");
            Console.WriteLine("Iterative Time Complexity: O(n)");
            Console.WriteLine("Iterative Space Complexity: O(1) - more memory efficient");
            Console.WriteLine("Use recursive approach for simplicity, iterative for performance.");
        }

        
        public static double CalculateFutureValueRecursive(double initialValue, double rate, int years)
        {
            if (years == 0)
                return initialValue;

            return CalculateFutureValueRecursive(initialValue, rate, years - 1) * (1 + rate);
        }


        public static double CalculateFutureValueIterative(double initialValue, double rate, int years)
        {
            double value = initialValue;
            for (int i = 1; i <= years; i++)
            {
                value *= (1 + rate);
            }
            return value;
        }
    }
}