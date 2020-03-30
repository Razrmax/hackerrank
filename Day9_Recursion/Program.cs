using System;

//https://www.hackerrank.com/challenges/30-recursion/problem
namespace Day9_Recursion
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Factorial(10, new int[11]));
        }

        static int Factorial(int n, int[] memo)
        {
            if (n < 2)
            {
                memo[n] = 1;
                return memo[n];
            }
            else if (memo[n] != 0)
            {
                return memo[n];
            }
            else
            {
                memo[n] = n * Factorial(n - 1, memo);
                return memo[n];
            }
        }
    }
}
