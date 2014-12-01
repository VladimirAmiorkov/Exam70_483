using System.ServiceModel;

namespace Example4._39
{
    // More info on how to create basic WCF Service project can be found at: http://msdn.microsoft.com/en-us/library/bb412178(v=vs.110).aspx
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    [ServiceContract]
    public class MyService
    {
        [OperationContract]
        public string DoWork(string left, string right)
        {
            return left + right;
        }
    }
}
