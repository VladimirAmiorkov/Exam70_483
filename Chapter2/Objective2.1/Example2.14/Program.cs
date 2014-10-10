
namespace Example2._14
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class MyClass<T> where T : class, new()
    {
        public MyClass()
        {
            MyProperty = new T();
        }

        T MyProperty { get; set; }
    }
}
