
namespace Example2._39
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IInterfaceA
    { 
        void MyMethod();
    }

    class Implementation : IInterfaceA
    {
        void IInterfaceA.MyMethod() { }
    }
}
