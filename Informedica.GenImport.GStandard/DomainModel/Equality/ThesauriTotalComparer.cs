using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel.Equality
{
    public class ThesauriTotalComparer : IEqualityComparer<IThesauriTotal>
    {
        #region Implementation of IEqualityComparer<in IThesauriTotal>

        public bool Equals(IThesauriTotal x, IThesauriTotal y)
        {
            return x.TsNr == y.TsNr &&
                   x.TsItNr == y.TsItNr;
        }

        public int GetHashCode(IThesauriTotal obj)
        {
            return obj.TsNr.GetHashCode() + obj.TsItNr.GetHashCode();
        }

        #endregion
    }
}
