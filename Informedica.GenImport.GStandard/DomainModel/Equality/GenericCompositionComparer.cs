using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel.Equality
{
    public class GenericCompositionComparer : IEqualityComparer<IGenericComposition>
    {
        #region Implementation of IEqualityComparer<in IGenericComposition>

        public bool Equals(IGenericComposition x, IGenericComposition y)
        {
            return x.GnMwHs == y.GnMwHs &&
                   x.GsKode == y.GsKode &&
                   x.GnNkPk == y.GnNkPk;
        }

        public int GetHashCode(IGenericComposition obj)
        {
            return obj.GnMwHs.GetHashCode() + obj.GsKode.GetHashCode() + obj.GnNkPk.GetHashCode();
        }

        #endregion
    }
}
