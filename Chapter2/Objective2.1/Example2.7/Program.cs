
namespace Example2._7
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private void MyMethod(int firstArgument, string secondArgument = "default value", bool thirdArgument = false)
        { 

        }

        private void CallingMethod()
        {
            MyMethod(1, thirdArgument: true);
        }
    }
}
