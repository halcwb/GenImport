using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel.Equality
{
    public class ProductComparer : IEqualityComparer<IProduct>
    {
        #region Implementation of IEqualityComparer<in IProduct>

        public bool Equals(IProduct x, IProduct y)
        {
            return x.AtKode == y.AtKode;
        }

        public int GetHashCode(IProduct obj)
        {
            return obj.AtKode.GetHashCode();
        }

        #endregion
    }
}
