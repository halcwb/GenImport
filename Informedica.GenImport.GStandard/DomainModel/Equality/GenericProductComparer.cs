using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel.Equality
{
    public class GenericProductComparer : IEqualityComparer<IGenericProduct>
    {
        #region Implementation of IEqualityComparer<in IGenericProduct>

        public bool Equals(IGenericProduct x, IGenericProduct y)
        {
            return x.GpKode == y.GpKode;
        }

        public int GetHashCode(IGenericProduct obj)
        {
            return obj.GpKode.GetHashCode();
        }

        #endregion
    }
}
