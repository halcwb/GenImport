using Informedica.GenImport.GStandard.Attributes;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel
{
    public class GeneriekeSamenstelling : IGeneriekeSamenstelling
    {
        #region Implementation of IGeneriekeSamenstelling

        /// <summary>
        /// Mutatiekode
        /// </summary>
        [FileLinePosition(5, 5)]
        public virtual MutKod MutKod { get; set; }

        /// <summary>
        /// Aanduiding werkzaam/hulpstof (W/H)
        /// </summary>
        [FileLinePosition(6, 6)]
        public virtual StofAanduiding GnMwHs { get; set; }

        /// <summary>
        /// GSK-code
        /// </summary>
        [FileLinePosition(7, 14)]
        [Modulo11]
        public virtual int GsKode { get; set; }

        /// <summary>
        /// Volledige generieke naam kode
        /// </summary>
        [FileLinePosition(15, 20)]
        [Modulo11]
        public virtual int GnNkPk { get; set; }

        /// <summary>
        /// Omgerekende hoeveelheid
        /// </summary>
        [FileLinePosition(21, 32)]
        [DecimalFormat(3)]
        public virtual decimal GnMomH { get; set; }

        /// <summary>
        /// Eenh omgerekende hoeveelheid kode
        /// </summary>
        [FileLinePosition(33, 35)]
        public virtual short XnMomE { get; set; }

        /// <summary>
        /// Basiseenheid product kode
        /// </summary>
        [FileLinePosition(36, 38)]
        public virtual short XpEhHv { get; set; }

        #endregion
    }
}