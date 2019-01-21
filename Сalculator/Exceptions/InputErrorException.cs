using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сalculator
{
    class InputErrorException: ApplicationException
    {
        public InputErrorException() { }
        public InputErrorException(string message) : base(message) { }
        public InputErrorException(string message, Exception inner) : base(message, inner) { }

    }
}
