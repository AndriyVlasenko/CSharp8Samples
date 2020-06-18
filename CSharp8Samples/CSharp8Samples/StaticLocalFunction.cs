using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Samples
{
    public class StaticLocalFunction
    {
        public static void Demo()
        {
            int y = 5;
            int x = 7;
            Console.WriteLine(Add(x, y));

            static int Add(int left, int right) => left + right;
        }
    }
}
