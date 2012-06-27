using System;
using Informedica.EntityRepository.Entities;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Attributes;

namespace Informedica.GenImport.GStandard.DomainModel
{
    public class Naam : Entity<Naam, int>, INaam
    {
        #region Implementation of INaam

        /// <summary>
        /// Mutatiekode
        /// </summary>
        [FileLinePosition(5, 5)]
        public virtual MutKod MutKod { get; set; }

        /// <summary>
        /// Naamnummer
        /// </summary>
        [FileLinePosition(6, 12)]
        public virtual int NmNr
        {
            get { return base.Id; }
            set { base.Id = value; }
        }

        /// <summary>
        /// Memokode
        /// </summary>
        [FileLinePosition(13, 18)]
        public virtual string NmMemo { get; set; }

        /// <summary>
        /// Etiketnaam
        /// </summary>
        [FileLinePosition(19, 45)]
        public virtual string NmEtiket { get; set; }

        /// <summary>
        /// Korte handelsnaam
        /// </summary>
        [FileLinePosition(46, 85)]
        public virtual string NmNm40 { get; set; }

        /// <summary>
        /// Naam volledig
        /// </summary>
        [FileLinePosition(86, 135)]
        public virtual string NmNaam { get; set; }

        #endregion

        #region Overrides of Entity<Naam,int>

        public override bool IsIdentical(Naam entity)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
