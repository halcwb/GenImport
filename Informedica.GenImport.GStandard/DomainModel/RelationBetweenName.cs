using System;
using Informedica.GenImport.GStandard.Attributes;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel
{
    public class RelationBetweenName : Entity<RelationBetweenName>, IRelationBetweenName
    {
        #region Implementation of IRelationBetweenName

        /// <summary>
        /// Mutatiekode
        /// </summary>
        [FileLinePosition(5, 5)]
        public virtual MutKod MutKod { get; set; }

        /// <summary>
        /// Relatie soort
        /// </summary>
        [FileLinePosition(6, 8)]
        public virtual int NmRNr { get; set; }

        /// <summary>
        /// Naamnummer ingang
        /// </summary>
        [FileLinePosition(9, 15)]
        public virtual int NmNrIn { get; set; }

        /// <summary>
        /// Naamnummer uitgang
        /// </summary>
        [FileLinePosition(16, 22)]
        public virtual int NmNrUit { get; set; }

        #endregion

        #region Overrides of Entity<RelationBetweenName,int>

        public override bool IsIdentical(RelationBetweenName entity)
        {
            return IsIdentical(entity);
        }

        #endregion

        #region Implementation of IEntity<in IRelationBetweenName,out int>

        public bool IsIdentical(IRelationBetweenName entity)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
