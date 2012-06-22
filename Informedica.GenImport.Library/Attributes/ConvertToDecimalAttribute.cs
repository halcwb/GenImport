using System;

namespace Informedica.GenImport.Library.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ConvertToDecimalAttribute : Attribute
    {
        public int Precision { get; set; }

        public ConvertToDecimalAttribute(int precision)
        {
            if (precision < 0) throw new ArgumentOutOfRangeException("precision", "Can't be less than 0.");
            Precision = precision;
        }

        public bool TryParse(string value, out decimal result)
        {
            result = 0;
            int intResult;
            bool parsed = Int32.TryParse(value, out intResult);
            if (parsed)
            {
                result = intResult / (decimal)(Math.Pow(10, Precision));
            }
            return parsed;
        }
    }
}
