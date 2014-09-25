using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1._81
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> calc = (x, y) =>
                {
                    Console.WriteLine(x + y);
                };

            calc(3, 4);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
