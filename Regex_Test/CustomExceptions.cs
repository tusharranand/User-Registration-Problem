using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_Test
{
    public class CustomExceptions : Exception
    {
        exceptionType type;
        public enum exceptionType
        {
            INVALID_FIRST_NAME,
            INVALID_LAST_NAME,
            INVALID_EMAIL,
            INVALID_MOBILE_NUMBER,
            INVALID_PASSWORD
        }
        public CustomExceptions(exceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
