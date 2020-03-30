﻿using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonacci(n));
        }

            public static int Fibonacci(int n) {
                if (n == 0) {
                    return 0;
                }
                else if (n == 1 || n == 2) {
                    return 1;
                }        
                else {
                    return Fibonacci(n - 1) + Fibonacci(n - 2);
                } 
        }
    }
}
