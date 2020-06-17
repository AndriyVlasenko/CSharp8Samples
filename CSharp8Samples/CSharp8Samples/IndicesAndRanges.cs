using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Samples
{
    public class IndicesAndRanges
    {
        private static string[] numbers =
        {              //from start   from end
            "One",     //  0          ^5
            "Two",     //  1          ^4 
            "Three",   //  2          ^3 
            "Four",    //  3          ^2 
            "Five"     //  4          ^1 
        };

        public static void GetLast()
        {
            Index i = ^1;
            Console.WriteLine(numbers[i]);
        }

        public static void GetLastTwo()
        {
            Range r = ^2..^0;
            var lastTwo = numbers[r];
            WriteStrings(lastTwo);
        }

        public static void GetAllNumbers()
        {
            //var allNumbers = numbers[..];
            //WriteStrings(allNumbers);
            var firstPartNumbers = numbers[..2];
            var secondPartNumbers = numbers[2..];
            WriteStrings(firstPartNumbers);
            WriteStrings(secondPartNumbers);
        }

        private static void WriteStrings(string[] strings)
        {
            foreach (var number in strings)
            {
                Console.WriteLine(number);
            }
        }

    }
}
