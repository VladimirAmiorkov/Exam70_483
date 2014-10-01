using System;

namespace Example1._96
{
    public class OrderProcessingException : Exception
    {
        public OrderProcessingException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
