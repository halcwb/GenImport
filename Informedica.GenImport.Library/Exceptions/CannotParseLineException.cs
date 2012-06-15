using System;

namespace Informedica.GenImport.Library.Exceptions
{
    public class CannotParseLineException : Exception
    {
        public CannotParseLineException()
            : this(null)
        {
        }

        public CannotParseLineException(Exception innerException)
            : base("Cannot parse line number.", innerException)
        {
        }

        public CannotParseLineException(int lineNumber)
            : this(lineNumber, null)
        {
        }

        public CannotParseLineException(int lineNumber, Exception innerException)
            : base(string.Format("Cannot parse line number: {0}.", lineNumber), innerException)
        {
        }
    }
}
