using System;

namespace Day7_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            if (n > 0 && n <= 1000)
            {
                if (arr.Length > n)
                {
                    Array.Resize(ref arr, n);
                }
                Array.Reverse(arr);

                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == arr.Length - 1)
                    {
                        Console.Write(arr[i]);
                    }
                    else
                    {
                        Console.Write(arr[i] + " ");
                    }
                }
            }
        }
    }
}
