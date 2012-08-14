using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel.Equality
{
    public class GenericNameComparer : IEqualityComparer<IGenericName>
    {
        #region Implementation of IEqualityComparer<in IGenericName>

        public bool Equals(IGenericName x, IGenericName y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (x == null || y == null) return false;
            return x.GnGnAm == y.GnGnAm &&
                x.GnGnK == y.GnGnK &&
                x.MutKod == y.MutKod;
        }

        public int GetHashCode(IGenericName obj)
        {
            return obj.GnGnK ^ obj.GnGnAm.GetHashCode() ^ (byte)obj.MutKod;
        }

        #endregion
    }
}
