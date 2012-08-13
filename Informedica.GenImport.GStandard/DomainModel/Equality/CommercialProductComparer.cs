using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel.Equality
{
    public class CommercialProductComparer : IEqualityComparer<ICommercialProduct>
    {
        #region Implementation of IEqualityComparer<in ICommercialProduct>

        public bool Equals(ICommercialProduct x, ICommercialProduct y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (x == null || y == null) return false;
            return x.FsNaam == y.FsNaam &&
                   x.HpKode == y.HpKode &&
                   x.HpNamN == y.HpNamN &&
                   x.MsNaam == y.MsNaam &&
                   x.MutKod == y.MutKod &&
                   x.TsEmbM == y.TsEmbM &&
                   x.XsEmbM == y.XsEmbM;
        }

        public int GetHashCode(ICommercialProduct obj)
        {
            return obj.FsNaam.GetHashCode() ^ obj.HpKode ^
                   obj.HpNamN ^ obj.MsNaam.GetHashCode() ^
                   (byte)obj.MutKod ^ obj.TsEmbM ^ obj.XsEmbM;
        }

        #endregion
    }
}
