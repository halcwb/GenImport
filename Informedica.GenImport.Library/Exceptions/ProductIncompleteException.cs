using System;

namespace Informedica.GenImport.Library.Exceptions
{
    public class ProductIncompleteException : Exception
    {
        public ProductIncompleteException(string message) : base(message)
        {
        }
    }
}