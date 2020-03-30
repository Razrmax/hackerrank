using System;
using System.Collections.Generic;
using System.Collections.Specialized;

// https://www.hackerrank.com/challenges/30-dictionaries-and-maps/problem?h_r=next-challenge&h_v=zen&isFullScreen=true&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
namespace Day8_Dictionary
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            int phonebookSize = Convert.ToInt32(Console.ReadLine());
            if (phonebookSize > 0 && phonebookSize < 1000000)
            {
                for (int i = 0; i < phonebookSize; i++)
                {
                    try
                    {
                        string input = Console.ReadLine();
                        string[] temp = input.Split(' ');
                        phoneBook.Add(temp[0], temp[1]);
                    }
                    catch (Exception)
                    {
                        i--;
                    }
                }

                DisplayPhoneBook(phoneBook);
            }
        }

        private static void DisplayPhoneBook(Dictionary<string,string> phoneBook)
        {
            string input;
            while ((input = Console.ReadLine()) != null)
            {
                try
                {
                    Console.WriteLine("{0}={1}", input, phoneBook[input]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
