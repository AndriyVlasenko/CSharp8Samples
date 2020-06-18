using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Samples
{
    public class StackallocNestedExpressions
    {
        public static void Demo()
        {
            Span<int> numbers = stackalloc[] { 1, 2, 3, 4, 5, 6 };
            var ind = numbers.IndexOfAny(stackalloc[] { 2, 4, 6, 8 });
            Console.WriteLine(ind);  // output: 1
        }
    }
}
