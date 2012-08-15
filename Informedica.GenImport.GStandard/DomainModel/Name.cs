using System;
using Informedica.GenImport.GStandard.Attributes;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel
{
    public class Name : Entity<Name>, IName
    {
        #region Implementation of IName

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
            get { return Id; } 
            set { Id = value; }
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

        public override bool IsIdentical(Name entity)
        {
            return IsIdentical(entity);
        }

        #endregion

        #region Implementation of IEntity<in IName,out int>

        public virtual bool IsIdentical(IName entity)
        {
            return entity.NmNr == NmNr;
        }

        #endregion

        #region Implementation of ICopyable<in IName>

        public virtual void CopyTo(IName other)
        {
            other.MutKod = MutKod;
            other.NmEtiket = NmEtiket;
            other.NmMemo = NmMemo;
            other.NmNaam = NmNaam;
            other.NmNm40 = NmNm40;
            other.NmNr = NmNr;
        }

        #endregion
    }
}
