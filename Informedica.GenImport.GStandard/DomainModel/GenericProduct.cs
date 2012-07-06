using System;
using Informedica.GenImport.GStandard.Attributes;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel
{
    public class GenericProduct : Entity<GenericProduct>, IGenericProduct
    {
        #region Implementation of IGenericProduct

        /// <summary>
        /// Mutatiekode
        /// </summary>
        [FileLinePosition(5, 5)]
        public virtual MutKod MutKod { get; set; }

        /// <summary>
        /// Generiekeproductcode (GPK)
        /// </summary>
        [FileLinePosition(6, 13)]
        [Modulo11]
        public virtual int GpKode { get; set; }

        /// <summary>
        /// GSK-code
        /// </summary>
        [FileLinePosition(14, 21)]
        [Modulo11]
        public virtual int GsKode { get; set; }

        /// <summary>
        /// Farmaceutische vorm thesaurusnummer
        /// </summary>
        [FileLinePosition(22, 24)]
        public virtual short ThKtVr { get; set; }

        /// <summary>
        /// Farmaceutische vorm code
        /// </summary>
        [FileLinePosition(25, 27)]
        public virtual short GpKtVr { get; set; }

        /// <summary>
        /// Toedieningsweg thesaurusnummer
        /// </summary>
        [FileLinePosition(28, 30)]
        public virtual short ThKTwg { get; set; }

        /// <summary>
        /// Toedieningsweg code
        /// </summary>
        [FileLinePosition(31, 33)]
        public virtual short GpKTwg { get; set; }

        /// <summary>
        /// Naamnummer volledige GPK-naam
        /// </summary>
        [FileLinePosition(34, 40)]
        public virtual int GpNmNr { get; set; }

        /// <summary>
        /// Naamnummer GPK-stofnaam
        /// </summary>
        [FileLinePosition(41, 47)]
        public virtual int GpStNr { get; set; }

        /// <summary>
        /// Ingegeven sterkte stofnamen
        /// </summary>
        [FileLinePosition(48, 72)]
        public virtual string GpInSt { get; set; }

        /// <summary>
        /// SuperProduktKode (SPK)
        /// </summary>
        [FileLinePosition(105, 112)]
        [Modulo11]
        public virtual int SpKode { get; set; }

        /// <summary>
        /// Basiseenheid product thesaurusnr
        /// </summary>
        [FileLinePosition(127, 129)]
        public virtual short ThEhHv { get; set; }

        /// <summary>
        /// Basiseenheid product kode
        /// </summary>
        [FileLinePosition(130, 132)]
        public virtual short XpEhHv { get; set; }

        #endregion

        #region Overrides of Entity<GeneriekProduct,int>

        public override bool IsIdentical(GenericProduct entity)
        {
            return IsIdentical(entity);
        }

        #endregion

        #region Implementation of IEntity<in IGenericProduct,out int>

        public virtual bool IsIdentical(IGenericProduct entity)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
