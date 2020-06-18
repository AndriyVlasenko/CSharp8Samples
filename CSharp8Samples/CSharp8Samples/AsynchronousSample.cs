
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp8Samples
{
    public class AsynchronousSample
    {
        //CSharp 8
        public static async Task AsynchronousStream8Demo()
        {
            await foreach (var data in GenerateSequence8())
            {
                Console.WriteLine(data);
            }
        }

        static async IAsyncEnumerable<int> GenerateSequence8()
        {
            for (int i = 1; i <= 10; i++)
            {
                await Task.Delay(1000);
                yield return i;
            }
        }

        //CSharp 7
        public static async Task AsynchronousStream7Demo()
        {
            foreach (var data in await GenerateSequence7())
            {
                Console.WriteLine(data);
            }
        }

        static async Task<IEnumerable<int>> GenerateSequence7()
        {
            List<int> dataList = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                await Task.Delay(1000);
                dataList.Add(i);
            }
            return dataList;
        }

        public static async Task AsyncDisposal()
        {
            //await using var resource = new DisposableObject();
            await using (var disposal = new DisposableObject())
            {
                // do something
            }
            //...
            Console.WriteLine("Release resource");
        }

    }

    public class DisposableObject : IAsyncDisposable, IDisposable
    {
        private bool disposed = false;

        public DisposableObject()
        {
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
            }

            disposed = true;
        }

        public virtual ValueTask DisposeAsync()
        {
            try
            {
                Dispose();
                return default;
            }
            catch (Exception exception)
            {
                return new ValueTask(Task.FromException(exception));
            }
        }
    }
}
