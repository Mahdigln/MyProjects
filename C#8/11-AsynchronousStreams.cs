using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8.Features
{
    public static class AsynchronousStreams
    {
        public static async IAsyncEnumerable<int> GenerateNumbers()
        {
            for (int i = 0; i < 50; i++)
            {
                await Task.Delay(500);
                yield return i;
            }
        }
    }
}
