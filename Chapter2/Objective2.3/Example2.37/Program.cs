using System;

namespace Example2._37
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Person
    {
        private string _firstName;

        public string FirstName
        {
            get { return this._firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }

                this._firstName = value;
            }
        }
    }
}
