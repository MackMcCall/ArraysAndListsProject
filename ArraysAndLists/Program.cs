using System;
using System.Collections.Generic;
using System.Globalization;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var first10 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                first10[i] = i + 1;
            }


            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            var odds = new List<int>();


            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (int num in first10)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("All even numbers from 1-10: ");
            foreach (int num in evens)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("All odd numbers from 1-10: ");
            foreach (int num in odds)
            {
                Console.WriteLine(num);
            }
        }
    }
}
