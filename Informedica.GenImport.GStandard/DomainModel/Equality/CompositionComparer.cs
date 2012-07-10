using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel.Equality
{
    public class CompositionComparer : IEqualityComparer<IComposition>
    {
        #region Implementation of IEqualityComparer<in IComposition>

        public bool Equals(IComposition x, IComposition y)
        {
            return x.SrtCde == y.SrtCde &&
                   x.Code == y.Code &&
                   x.GnGnK == y.GnGnK &&
                   x.GnHoev == y.GnHoev &&
                   x.GnEenh == y.GnEenh;
        }

        public int GetHashCode(IComposition obj)
        {
            return obj.SrtCde.GetHashCode() + obj.Code.GetHashCode() + obj.GnGnK.GetHashCode() +
                   obj.GnHoev.GetHashCode() + obj.GnEenh.GetHashCode();
        }

        #endregion
    }
}
