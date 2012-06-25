using System;

namespace Informedica.GenImport.GStandard.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class BooleanFormatAttribute : Attribute
    {
        public string TrueString { get; set; }
        public string FalseString { get; set; }

        public BooleanFormatAttribute(string trueString, string falseString)
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
