using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example1._7
{
    public static class Program
    {
        public static void Main()
        {
            ThreadPool.QueueUserWorkItem((s) =>
                {
                    Console.WriteLine("working on thread from threadpool.");
                });
            Console.ReadKey();
        }
    }
}
