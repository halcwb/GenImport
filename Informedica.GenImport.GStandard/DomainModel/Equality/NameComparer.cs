using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel.Equality
{
    public class NameComparer : IEqualityComparer<IName>
    {
        #region Implementation of IEqualityComparer<in INaam>

        public bool Equals(IName x, IName y)
        {
            return x.NmNaam == y.NmNaam;
        }

        public int GetHashCode(IName obj)
        {
            return obj.NmNaam.GetHashCode();
        }

        #endregion
    }
}
