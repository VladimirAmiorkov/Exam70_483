
namespace Example2._34
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Derived();
            obj.MyDerivedMethod();
        }
    }

    public class Base
    {
        private int _privateField = 42;
        protected int _protectedField = 42;

        private void MyPrivateMethod() { }
        protected void MyProtectedMethod() { }
    }

    public class Derived : Base
    {
        public void MyDerivedMethod()
        {
            // _privateField = 41; // Not OK, this will generate a compile error
            _protectedField = 43; // OK, protected fields can be accessed

            // MyPrivateMethod(); // Not OK, this will generate a compile error
            MyProtectedMethod(); // OK, protected methods can be accessed
        }
    }
}
