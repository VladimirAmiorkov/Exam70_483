using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1._35
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            var up = Task.Run(() =>
                {
                    for (int i = 0; i < 1000000; i++)
                    {
                        n++;
                    }
                });

            for (int i = 0; i < 1000000; i++)
            {
                n--;
            }

            up.Wait();
            Console.WriteLine(n);

            Console.ReadKey();
        }
    }
}
