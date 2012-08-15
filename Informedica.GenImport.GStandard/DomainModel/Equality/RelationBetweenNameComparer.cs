using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel.Equality
{
    public class RelationBetweenNameComparer : IEqualityComparer<IRelationBetweenName>
    {
        #region Implementation of IEqualityComparer<in IRelationBetweenName>

        public bool Equals(IRelationBetweenName x, IRelationBetweenName y)
        {
            return x.MutKod == y.MutKod &&
                   x.NmNrIn == y.NmNrIn &&
                   x.NmNrUit == y.NmNrUit &&
                   x.NmRNr == y.NmRNr;
        }

        public int GetHashCode(IRelationBetweenName obj)
        {
            return (byte)obj.MutKod ^ obj.NmNrIn ^ obj.NmNrUit ^ obj.NmRNr;
        }

        #endregion
    }
}
