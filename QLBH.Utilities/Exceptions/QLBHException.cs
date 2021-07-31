using System;

namespace QLBH.Utilities.Exceptions
{
    public class QLBHException : Exception
    {
        public QLBHException()
        {
        }

        public QLBHException(string message)
            : base(message)
        {
        }

        public QLBHException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
