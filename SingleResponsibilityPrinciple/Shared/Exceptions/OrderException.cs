using System;

namespace SOLID.Shared.Exceptions
{
    public class OrderException : Exception
    {
        public OrderException(string message, Exception innerException) : base(message, innerException)
        { }
    }
}
