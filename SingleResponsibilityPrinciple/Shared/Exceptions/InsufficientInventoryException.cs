using System;

namespace SOLID.Shared.Exceptions
{
    public class InsufficientInventoryException : Exception
    {
        public InsufficientInventoryException() : base("Insufficient inventory")
        { }
    }
}
