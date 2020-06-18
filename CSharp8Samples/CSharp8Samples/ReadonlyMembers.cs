using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CSharp8Samples
{
    public class ReadonlyMembers
    {
        public static void WriteReadOnlyStruct()
        {
            Point p = new Point { X = 10, Y = 20 };
            Console.WriteLine(p);
        }
    }

    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Distance => Math.Sqrt(X * X + Y * Y);
        public override string ToString() =>
            $"({X}, {Y}) is {Distance} from the origin";
    }
}
