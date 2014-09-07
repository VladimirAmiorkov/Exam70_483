using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1._22
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 100);
            var parallelResult = numbers.AsParallel()
                .Where(i => i %5 == 0)
                .ToArray();
            StringBuilder result = new StringBuilder();

            foreach (var number in parallelResult)
            {
                result.AppendLine(number.ToString());
            }

            Console.Write(result);
            Console.ReadKey();
        }
    }
}
