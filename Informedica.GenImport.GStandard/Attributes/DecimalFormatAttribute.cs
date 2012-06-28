using System;

namespace Informedica.GenImport.GStandard.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DecimalFormatAttribute : Attribute
    {
        public int Scale { get; set; }

        public DecimalFormatAttribute(int scale)
        {
            if (scale < 0) throw new ArgumentOutOfRangeException("scale", "Can't be less than 0.");
            Scale = scale;
        }

        public bool TryParse(string value, out decimal result)
        {
            result = 0;
            int intResult;
            bool parsed = Int32.TryParse(value, out intResult);
            if (parsed)
            {
                result = intResult / (decimal)(Math.Pow(10, Scale));
            }
            return parsed;
        }
    }
}
