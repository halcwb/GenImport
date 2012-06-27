﻿using Informedica.GenImport.GStandard.Attributes;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel
{
    public class PrescriptieProduct : IPrescriptieProduct
    {
        #region Implementation of IPrescriptieProduct

        /// <summary>
        /// Mutatiekode
        /// </summary>
        [FileLinePosition(5, 5)]
        public virtual MutKod MutKod { get; set; }

        /// <summary>
        /// PRK-code
        /// </summary>
        [FileLinePosition(6, 13)]
        [Modulo11]
        public virtual int PrKode { get; set; }

        /// <summary>
        /// Naamnummer prescriptie product
        /// </summary>
        [FileLinePosition(14, 20)]
        public virtual int PrNmNr { get; set; }

        /// <summary>
        /// Verwijzing naar kenmerken bestand
        /// </summary>
        [FileLinePosition(21, 30)]
        public virtual string PrKBst { get; set; }

        #endregion
    }
}