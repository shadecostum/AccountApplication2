using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApplication2.InsufficientBalance
{
    internal class InsufficentBalanceException:Exception
    {
        public InsufficentBalanceException(string message) : base(message) { }
    }
}
