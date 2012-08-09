using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel.Equality
{
    public class RelationBetweenNameComparer : IEqualityComparer<IRelationBetweenName>
    {
        #region Implementation of IEqualityComparer<in IRelationBetweenName>

        public bool Equals(IRelationBetweenName x, IRelationBetweenName y)
        {
            return x.NmRNr == y.NmRNr &&
                   x.NmNrIn == y.NmNrIn &&
                   x.NmNrUit == y.NmNrUit;
        }

        public int GetHashCode(IRelationBetweenName obj)
        {
            return obj.NmRNr.GetHashCode() + obj.NmNrIn.GetHashCode() + obj.NmNrUit.GetHashCode();
        }

        #endregion
    }
}
