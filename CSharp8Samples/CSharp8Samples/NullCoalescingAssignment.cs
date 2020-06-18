using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Samples
{
    public class NullCoalescingAssignment
    {
        public static void Demo()
        {
            List<int> numbers = null;
            int? i = null;

            numbers ??= new List<int>();
            numbers.Add(i ??= 17);
            numbers.Add(i ??= 20);

            Console.WriteLine(string.Join(" ", numbers));  // output: 17 17
            Console.WriteLine(i);  // output: 17
        }
    }
}
