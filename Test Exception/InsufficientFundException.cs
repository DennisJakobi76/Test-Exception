using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Exception
{
    internal class InsufficientFundException: Exception
    {
        public InsufficientFundException()
        {
        }
        public InsufficientFundException(string message)
            : base(message)
        {
        }
        public InsufficientFundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
