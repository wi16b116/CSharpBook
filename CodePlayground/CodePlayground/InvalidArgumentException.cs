using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePlayground
{
    class InvalidArgumentException : ApplicationException
    {
        public InvalidArgumentException():base("Divide by zero error.")
        {

        }

        public InvalidArgumentException(string message) : base(message)
        {

        }
    }
}
