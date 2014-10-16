using System;
using System.Dynamic;

namespace Example2._29
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic obj = new SampleObject();
            Console.WriteLine(obj.SomeProperty);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }

    public class SampleObject : DynamicObject
    {
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            result = binder.Name;
            return true;
        }
    }
}
