using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel.Equality
{
    public class GenericProductComparer : IEqualityComparer<IGenericProduct>
    {
        #region Implementation of IEqualityComparer<in IGenericProduct>

        public bool Equals(IGenericProduct x, IGenericProduct y)
        {
            return x.GpInSt == y.GpInSt &&
                   x.GpKode == y.GpKode &&
                   x.GpKtVr == y.GpKtVr &&
                   x.GpKTwg == y.GpKTwg &&
                   x.GpNmNr == y.GpNmNr &&
                   x.GpStNr == y.GpStNr &&
                   x.GsKode == y.GsKode &&
                   x.MutKod == y.MutKod &&
                   x.SpKode == y.SpKode &&
                   x.ThEhHv == y.ThEhHv &&
                   x.ThKtVr == y.ThKtVr &&
                   x.ThKTwg == y.ThKTwg &&
                   x.XpEhHv == y.XpEhHv;
        }

        public int GetHashCode(IGenericProduct obj)
        {
            return obj.GpInSt.GetHashCode() ^ obj.GpKode ^ obj.GpKtVr ^
                   obj.GpKTwg ^ obj.GpNmNr ^
                   obj.GpStNr ^ obj.GsKode ^ (byte)obj.MutKod ^
                   obj.SpKode ^ obj.ThEhHv ^ obj.ThKtVr ^
                   obj.ThKTwg ^ obj.XpEhHv;
        }

        #endregion
    }
}
