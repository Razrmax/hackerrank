using System;

//https://www.hackerrank.com/challenges/ctci-recursive-staircase/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=recursion-backtracking&h_r=next-challenge&h_v=zen

namespace DavisStairs.Standard
{
    class Program
    {
        static int[] _cachedResults = {1,1,2,4};
        static void Main()
        {
            

            int s = Convert.ToInt32(Console.ReadLine());
            int[] tempMemo;

            for (int sItr = 0; sItr < s; sItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > _cachedResults.Length - 1) {
                    tempMemo = new int[n + 1];
                    Array.Copy(_cachedResults, 0, tempMemo, 0, _cachedResults.Length);
                    _cachedResults = tempMemo;
                }
                int res = StepPerms(n);
                Console.WriteLine(res);
            }          
            
        }
        static int StepPerms(int n)
        {
            if (_cachedResults[n] != 0) {
                return _cachedResults[n];
            }

            else {                
                int result = StepPerms(n-1) + StepPerms(n-2) + StepPerms(n-3);
                _cachedResults[n] = result;   
                return result;
            }
        }
    }
}
