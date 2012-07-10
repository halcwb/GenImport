using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel.Equality
{
    public class CommercialProductComparer : IEqualityComparer<ICommercialProduct>
    {
        #region Implementation of IEqualityComparer<in ICommercialProduct>

        public bool Equals(ICommercialProduct x, ICommercialProduct y)
        {
            //TODO check if this is correct
            return x.FsNaam == y.FsNaam &&
                   x.MsNaam == y.MsNaam;
        }

        public int GetHashCode(ICommercialProduct obj)
        {
            return obj.FsNaam.GetHashCode() + obj.MsNaam.GetHashCode();
        }

        #endregion
    }
}
