﻿using Informedica.GenImport.GStandard.Attributes;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel
{
    public class HandelsProduct : IHandelsProduct
    {
        #region Implementation of IHandelsProduct

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
        public virtual int HpKode { get; set; }

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
    }
}
