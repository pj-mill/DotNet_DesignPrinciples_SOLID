using System;

namespace SOLID.Shared.Exceptions
{
    public class InsufficientAccountBalanceException : Exception
    {
        public InsufficientAccountBalanceException() : base("Insufficient funds in account")
        { }
    }
}
