using System;
using System.Net.Http;

namespace Example2._21
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            object o = client;
            IDisposable d = client;

            Console.WriteLine("client = {0}", client);
            Console.WriteLine("o = {0}", o);
            Console.WriteLine("d = {0}", d);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
