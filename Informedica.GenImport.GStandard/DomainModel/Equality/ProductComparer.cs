using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel.Equality
{
    public class ProductComparer : IEqualityComparer<IProduct>
    {
        #region Implementation of IEqualityComparer<in IProduct>

        public bool Equals(IProduct x, IProduct y)
        {
            return x.AtKode == y.AtKode &&
                   x.AtNmNr == y.AtNmNr &&
                   x.HpKode == y.HpKode &&
                   x.MutKod == y.MutKod;
        }

        public int GetHashCode(IProduct obj)
        {
            return obj.AtKode ^ obj.AtNmNr ^ obj.HpKode ^ (byte)obj.MutKod;
        }

        #endregion
    }
}
