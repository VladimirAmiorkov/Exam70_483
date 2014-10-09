using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2._12
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class ConstructorChaning
    {
        private int p;

        public ConstructorChaning() : this(3){ }

        public ConstructorChaning(int p)
        {
            this.p = p;
        }
    }
}
