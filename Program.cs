using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> myDictionary = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!myDictionary.ContainsKey(input[i]))
                {
                    myDictionary.Add(input[i], 1);
                }

                else
                {
                    myDictionary[input[i]] += 1;
                }

            }

           

            foreach (var symbol in myDictionary)
            {
                Console.WriteLine($"{symbol}: {myDictionary[symbol.Key]} time/s ");
            }
        }
    }
}
