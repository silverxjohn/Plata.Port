using System;

namespace Plata.Port
{
    public class InvalidBitException : Exception
    {
        public InvalidBitException(string message) : base(message)
        {

        }
    }
}
