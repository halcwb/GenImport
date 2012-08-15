using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel.Equality
{
    public class ThesauriTotalComparer : IEqualityComparer<IThesauriTotal>
    {
        #region Implementation of IEqualityComparer<in IThesauriTotal>

        public bool Equals(IThesauriTotal x, IThesauriTotal y)
        {
            return x.MutKod == y.MutKod &&
                   x.ThAKd1 == y.ThAKd1 &&
                   x.ThAKd2 == y.ThAKd2 &&
                   x.ThAKd3 == y.ThAKd3 &&
                   x.ThAKd4 == y.ThAKd4 &&
                   x.ThAKd5 == y.ThAKd5 &&
                   x.ThAKd6 == y.ThAKd6 &&
                   x.ThItMk == y.ThItMk &&
                   x.ThNm15 == y.ThNm15 &&
                   x.ThNm25 == y.ThNm25 &&
                   x.ThNm4 == y.ThNm4 &&
                   x.ThNm50 == y.ThNm50 &&
                   x.TsNr == y.TsNr &&
                   x.TsItNr == y.TsItNr;
        }

        public int GetHashCode(IThesauriTotal obj)
        {
            return (byte)obj.MutKod ^ obj.ThAKd1.GetHashCode() ^ obj.ThAKd2.GetHashCode() ^
                   obj.ThAKd3.GetHashCode() ^ obj.ThAKd4.GetHashCode() ^
                   obj.ThAKd5.GetHashCode() ^ obj.ThAKd6.GetHashCode() ^
                   obj.ThItMk.GetHashCode() ^ obj.ThNm15.GetHashCode() ^
                   obj.ThNm25.GetHashCode() ^ obj.ThNm4.GetHashCode() ^
                   obj.ThNm50.GetHashCode() ^ obj.TsNr ^ obj.TsItNr;
        }

        #endregion
    }
}
