using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel.Equality
{
    public class GenericNameComparer : IEqualityComparer<IGenericName>
    {
        #region Implementation of IEqualityComparer<in IGenericName>

        public bool Equals(IGenericName x, IGenericName y)
        {
            return x.GnGnK == y.GnGnK;
        }

        public int GetHashCode(IGenericName obj)
        {
            return obj.GnGnK.GetHashCode();
        }

        #endregion
    }
}
