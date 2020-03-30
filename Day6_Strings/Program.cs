using System;
//https://www.hackerrank.com/challenges/30-review-loop/problem?h_r=next-challenge&h_v=zen&isFullScreen=true&h_r=next-challenge&h_v=zen

namespace Day6_Strings
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int counter = Convert.ToInt32(input);
            if (counter > 0 && counter < 11)
            {
                string[] s = new string[counter];

                for (int i = 0; i < counter; i++)
                {
                    input = Console.ReadLine();
                    s[i] = GetSubstring(input, true) + " " + GetSubstring(input, false);
                }

                DisplayResult(s);
            }

            
        }
        /// <summary>
        /// Gets the string str and generates a new string of chars from the source strings with even or odd indices
        /// </summary>
        /// <param name="str">source string</param>
        /// <param name="isEven">true if substring of values with even source indices required</param>
        /// <returns>source</returns>
        static string GetSubstring(string str, bool isEven)
        {
            string subStr = "";

            for (int i = isEven ? 0 : 1; i < str.Length; i += 2)
            {
                subStr += str.Substring(i, 1);
            }

            return subStr;
        }

        static void DisplayResult(string[] strArr)
        {
            foreach (string s in strArr)
            {
                Console.WriteLine(s);
            }
        }
    }
}
