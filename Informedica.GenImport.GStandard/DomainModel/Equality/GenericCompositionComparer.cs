using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel.Equality
{
    public class GenericCompositionComparer : IEqualityComparer<IGenericComposition>
    {
        #region Implementation of IEqualityComparer<in IGenericComposition>

        public bool Equals(IGenericComposition x, IGenericComposition y)
        {
            return x.GnMomH == y.GnMomH &&
                   x.GnMwHs == y.GnMwHs &&
                   x.GnNkPk == y.GnNkPk &&
                   x.GsKode == y.GsKode &&
                   x.MutKod == y.MutKod &&
                   x.XnMomE == y.XnMomE &&
                   x.XpEhHv == y.XpEhHv;
        }

        public int GetHashCode(IGenericComposition obj)
        {
            return obj.GnMomH.GetHashCode() ^ (byte)obj.GnMwHs ^
                   obj.GnNkPk ^ obj.GsKode ^
                   (byte)obj.MutKod ^ obj.XnMomE ^
                   obj.XpEhHv;
        }

        #endregion
    }
}
