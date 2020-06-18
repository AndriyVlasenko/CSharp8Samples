using System;
using System.Threading.Tasks;

namespace CSharp8Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            //await AsynchronousSample.AsynchronousStream7Demo();
            //await AsynchronousSample.AsynchronousStream8Demo();
            //await AsynchronousSample.AsyncDisposal();

            //IndicesAndRanges.GetLast();
            //IndicesAndRanges.GetLastTwo();
            //IndicesAndRanges.GetAllNumbers();

            //PatternMatching.IsExpression();
            //PatternMatching.SwitchExpression();
            //PatternMatching.TuplePatterns();

            NullableReferenceTypes.Demo();

            ReadonlyMembers.WriteReadOnlyStruct();

            Console.ReadLine();
        }
    }
}
