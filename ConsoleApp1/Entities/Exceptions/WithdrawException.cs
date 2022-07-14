using System;

namespace ConsoleApp1.Entities.Exceptions
{
    internal class WithdrawException : ApplicationException
    {
        public WithdrawException(string message): base(message)
        {

        }
    }
}
