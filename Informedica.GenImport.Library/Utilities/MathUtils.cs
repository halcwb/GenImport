using System;

namespace Informedica.GenImport.Library.Utilities
{
    public class MathUtils
    {
        public static bool IsValidModulo11(int value)
        {
            short intLength = IntLength(value);

            int divisor = (int)Math.Pow(10, intLength);
            int total = 0;

            int result = value;
            for (int i = intLength; i >= 1; i--)
                total += i * Math.DivRem(result, divisor /= 10, out result);

            return total % 11 == 0;
        }

        public static short IntLength(int i)
        {
            if (i < 0) throw new ArgumentOutOfRangeException();
            if (i == 0) return 1;

            return (short)(Math.Floor(Math.Log10(i)) + 1);
        }
    }
}
