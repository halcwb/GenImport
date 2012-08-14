using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel.Equality
{
    public class PrescriptionProductComparer : IEqualityComparer<IPrescriptionProduct>
    {
        #region Implementation of IEqualityComparer<in IPrescriptionProduct>

        public bool Equals(IPrescriptionProduct x, IPrescriptionProduct y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (x == null || y == null) return false;

            return x.MutKod == y.MutKod &&
                   x.PrKode == y.PrKode &&
                   x.PrNmNr == y.PrNmNr;
        }

        public int GetHashCode(IPrescriptionProduct obj)
        {
            return (byte)obj.MutKod ^ obj.PrKode ^ obj.PrNmNr;
        }

        #endregion
    }
}
