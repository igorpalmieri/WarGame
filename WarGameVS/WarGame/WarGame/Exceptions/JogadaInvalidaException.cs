using System;
using System.Runtime.Serialization;

namespace WarGame.Exceptions
{
    [Serializable]
    public class JogadaInvalidaException : Exception
    {
        public JogadaInvalidaException()
        {
        }

        public JogadaInvalidaException(string message) : base(message)
        {
        }

        public JogadaInvalidaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected JogadaInvalidaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}