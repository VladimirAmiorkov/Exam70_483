
namespace Example2._32
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Accessibility
    {
        private string _myField;

        public string MyProperty
        {
            get { return this._myField; }
            set { _myField = value; }
        }
    }
}
