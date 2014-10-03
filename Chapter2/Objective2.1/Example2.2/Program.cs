using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(1, 1);
        }
    }

    public struct Point
    {
        public int x, y;

        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }
}
