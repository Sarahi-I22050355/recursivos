using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursivos
{
    internal class Program
    {
        // Recursive method to calculate the factorial of a number
        static long RecursiveFactorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * RecursiveFactorial(n - 1);
        }

        // Recursive method to calculate the sum of natural numbers up to n
        static int RecursiveNaturalSum(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            return n + RecursiveNaturalSum(n - 1);
        }

        // Recursive method to calculate the n-th Fibonacci number
        static int RecursiveFibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }
        static void Main(string[] args)
        {
            int number = 5;
            int n = 10;

            // Calculate factorial recursively
            long recursiveFactorial = RecursiveFactorial(number);
            Console.WriteLine($"Factorial of {number} (Recursive): {recursiveFactorial}");

            // Calculate the sum of natural numbers recursively up to n
            int recursiveSum = RecursiveNaturalSum(n);
            Console.WriteLine($"Sum of naturals up to {n} (Recursive): {recursiveSum}");

            // Calculate the n-th Fibonacci number recursively
            int recursiveFibonacci = RecursiveFibonacci(n);
            Console.WriteLine($"Fibonacci({n}) (Recursive): {recursiveFibonacci}");
        }
    }
}
