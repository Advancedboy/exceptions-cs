using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class MyOwnException : Exception
    {
        public MyOwnException() : base("This is my Exception")
        {
        }

        public MyOwnException(string message) : base(message)
        {
        }
    }
}
