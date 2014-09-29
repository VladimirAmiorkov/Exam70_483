using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1._92
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the special '42' number: ");
            string s = Console.ReadLine();
            try
            {
                int i = int.Parse(s);
                if (i == 42)
                {
                    Environment.FailFast("Special number entered");
                }
            }
            finally
            {
                Console.WriteLine("Program complete.");
            }
        }
    }
}
