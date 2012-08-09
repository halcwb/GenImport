using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel.Equality
{
    public class PrescriptionProductComparer : IEqualityComparer<IPrescriptionProduct>
    {
        #region Implementation of IEqualityComparer<in IPrescriptionProduct>

        public bool Equals(IPrescriptionProduct x, IPrescriptionProduct y)
        {
            return x.PrKode == y.PrKode;
        }

        public int GetHashCode(IPrescriptionProduct obj)
        {
            return obj.PrKode.GetHashCode();
        }

        #endregion
    }
}
