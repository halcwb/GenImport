using System;
using Informedica.GenImport.GStandard.Attributes;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel
{
    public class GenericName : Entity<GenericName>, IGenericName
    {
        #region Implementation of IGeneriekeNaam

        /// <summary>
        /// Mutatiekode
        /// </summary>
        [FileLinePosition(5, 5)]
        public virtual MutKod MutKod { get; set; }

        /// <summary>
        /// GeneriekeNaamKode (GNK)
        /// </summary>
        [FileLinePosition(6, 11)]
        [Modulo11]
        public virtual int GnGnK
        {
            get { return Id; }
            set { Id = value; }
        }

        /// <summary>
        /// Generieke naam
        /// </summary>
        [FileLinePosition(12, 61)]
        public virtual string GnGnAm { get; set; }

        #endregion

        #region Overrides of Entity<GeneriekeNaam,int>

        public override bool IsIdentical(GenericName entity)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
