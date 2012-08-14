using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel.Equality
{
    public class CompositionComparer : IEqualityComparer<IComposition>
    {
        #region Implementation of IEqualityComparer<in IComposition>

        public bool Equals(IComposition x, IComposition y)
        {
            return x.Code == y.Code &&
                   x.GnEenh == y.GnEenh &&
                   x.GnGnK == y.GnGnK &&
                   x.GnHoev == y.GnHoev &&
                   x.GnStam == y.GnStam &&
                   x.MutKod == y.MutKod &&
                   x.SrtCde == y.SrtCde &&
                   x.StAdd == y.StAdd &&
                   x.StEenh == y.StEenh &&
                   x.StHoev == y.StHoev &&
                   x.ThsrTc == y.ThsrTc &&
                   x.TsGneH == y.TsGneH &&
                   x.TsStEh == y.TsStEh;
        }

        public int GetHashCode(IComposition obj)
        {
            return obj.Code ^ obj.GnEenh ^ obj.GnGnK ^
                   obj.GnHoev.GetHashCode() ^ obj.GnStam ^
                   (byte)obj.MutKod ^ obj.SrtCde ^ obj.StAdd.GetHashCode() ^
                   obj.StEenh ^ obj.StHoev.GetHashCode() ^
                   obj.ThsrTc ^ obj.TsGneH ^ obj.TsStEh;
        }

        #endregion
    }
}
