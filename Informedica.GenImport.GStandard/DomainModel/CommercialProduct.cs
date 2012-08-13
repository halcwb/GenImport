using System;
using Informedica.GenImport.GStandard.Attributes;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel
{
    public class CommercialProduct : Entity<CommercialProduct>, ICommercialProduct
    {
        #region Implementation of ICommercialProduct

        /// <summary>
        /// Mutatiekode
        /// </summary>
        [FileLinePosition(5, 5)]
        public virtual MutKod MutKod { get; set; }

        /// <summary>
        /// Handelsproduktkode
        /// </summary>
        [FileLinePosition(6, 13)]
        [Modulo11]
        public virtual int HpKode
        {
            get { return Id; } 
            set { Id = value; }
        }

        /// <summary>
        /// Handelsproduktnaamnummer
        /// </summary>
        [FileLinePosition(30, 36)]
        public virtual int HpNamN { get; set; }

        /// <summary>
        /// Merkstamnaam
        /// </summary>
        [FileLinePosition(37, 86)]
        public virtual string MsNaam { get; set; }

        /// <summary>
        /// Firmastamnaam
        /// </summary>
        [FileLinePosition(87, 136)]
        public virtual string FsNaam { get; set; }

        /// <summary>
        /// Emballagemateriaal thesaurusnummer
        /// </summary>
        [FileLinePosition(266, 269)]
        public virtual short TsEmbM { get; set; }

        /// <summary>
        /// Emballagemateriaal kode
        /// </summary>
        [FileLinePosition(270, 275)]
        public virtual int XsEmbM { get; set; }

        #endregion

        #region Overrides of Entity<CommercialProduct,int>

        public override bool IsIdentical(CommercialProduct entity)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Implementation of IEntity<in ICommercialProduct,out int>

        public virtual bool IsIdentical(ICommercialProduct entity)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Implementation of ICopyable<in ICommercialProduct>

        public void CopyTo(ICommercialProduct other)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
