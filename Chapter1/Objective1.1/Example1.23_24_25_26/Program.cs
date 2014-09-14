using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1._23
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 10);

            // 1.23
            // In no particular order
            //var parallelResult = numbers.AsParallel().
            //    .Where(i => i % 2 == 0)
            //    .ToArray();

            // 1.24
            // Order
            //var parallelResult = numbers.AsParallel().AsOrdered()
            //    .Where(i => i % 2 == 0)
            //    .ToArray();

            //foreach (var number in parallelResult)
            //{
            //    Console.WriteLine(number);
            //}

            // 1.25
            //var parallelResult = numbers.AsParallel().AsOrdered()
            //    .Where(i => i % 2 == 0)
            //    .AsSequential();

            //foreach (var number in parallelResult.Take(5))
            //{
            //    Console.WriteLine(number);
            //}

            // 1.26
            var parallelResult = numbers.AsParallel()
                .Where(i => i % 2 == 0);
            parallelResult.ForAll(e => Console.WriteLine(e));

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
