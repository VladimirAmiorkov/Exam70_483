
namespace Example2._33
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Accessibility
    {
        // initialization code and error checking omitted
        private string[] _myField;

        public string MyProperty
        {
            get { return _myField[0]; }
            set { _myField[0] = value; }
        }
    }
}
