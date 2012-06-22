using System;

namespace Informedica.GenImport.Library.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ConvertToBooleanAttribute : Attribute
    {
        public string TrueString { get; set; }
        public string FalseString { get; set; }

        public ConvertToBooleanAttribute(string trueString, string falseString)
        {
            TrueString = trueString;
            FalseString = falseString;
        }

        public bool TryParse(string value, out bool result)
        {
            result = false;
            if (value == TrueString) { 
                result = true;
                return true;
            }
            return value == FalseString;
        }
    }
}
