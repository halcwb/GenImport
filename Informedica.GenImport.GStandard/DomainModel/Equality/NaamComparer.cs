using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel.Equality
{
    public class NaamComparer : IEqualityComparer<INaam>
    {
        #region Implementation of IEqualityComparer<in INaam>

        public bool Equals(INaam x, INaam y)
        {
            return x.NmNaam == y.NmNaam;
        }

        public int GetHashCode(INaam obj)
        {
            return obj.NmNaam.GetHashCode();
        }

        #endregion
    }
}
