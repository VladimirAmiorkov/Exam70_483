using System;

namespace Example3._41
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeMethod();

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }

        public static void SomeMethod()
        {
#if DEBUG
            Log("Step1");
#endif
        }

        private static void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
