using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel.Equality
{
    public class NameComparer : IEqualityComparer<IName>
    {
        #region Implementation of IEqualityComparer<in INaam>

        public bool Equals(IName x, IName y)
        {
            return
                x.MutKod == y.MutKod &&
                x.NmEtiket == y.NmEtiket &&
                x.NmMemo == y.NmMemo &&
                x.NmNaam == y.NmNaam &&
                x.NmNm40 == y.NmNm40 &&
                x.NmNr == y.NmNr;
        }

        public int GetHashCode(IName obj)
        {
            return (byte)obj.MutKod ^ obj.NmEtiket.GetHashCode() ^ obj.NmMemo.GetHashCode() ^
                   obj.NmNaam.GetHashCode() ^ obj.NmNm40.GetHashCode() ^ obj.NmNr;
        }

        #endregion
    }
}
