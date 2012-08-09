using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel.Equality
{
    public class CommercialProductComparer : IEqualityComparer<ICommercialProduct>
    {
        #region Implementation of IEqualityComparer<in ICommercialProduct>

        public bool Equals(ICommercialProduct x, ICommercialProduct y)
        {
            return x.HpKode == y.HpKode;
        }

        public int GetHashCode(ICommercialProduct obj)
        {
            return obj.HpKode.GetHashCode();
        }

        #endregion
    }
}
