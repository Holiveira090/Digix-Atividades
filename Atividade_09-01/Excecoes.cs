using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_09_01
{
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message) { }
    }

    public class InvalidDepositAmountException : Exception
    {
        public InvalidDepositAmountException(string message) : base(message) { }
    }

    public class AccountNotFoundException : Exception
    {
        public AccountNotFoundException(string message) : base(message) { }
    }

    public class InvalidPinException : Exception
    {
        public InvalidPinException(string message) : base(message) { }
    }

}