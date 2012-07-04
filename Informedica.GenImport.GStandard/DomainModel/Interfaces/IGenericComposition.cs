using Informedica.GenImport.GStandard.DomainModel.Enums;

namespace Informedica.GenImport.GStandard.DomainModel.Interfaces
{
    /// <summary>
    /// Contract for a line in G-Standard file 715.
    /// </summary>
    public interface IGenericComposition : IGStandardModel
    {
        /// <summary>
        /// Mutatiekode
        /// </summary>
        MutKod MutKod { get; set; }
        /// <summary>
        /// Aanduiding werkzaam/hulpstof (W/H)
        /// </summary>
        SubstanceIndication GnMwHs { get; set; }
        /// <summary>
        /// GSK-code
        /// </summary>
        int GsKode { get; set; }
        /// <summary>
        /// Volledige generieke naam kode
        /// </summary>
        int GnNkPk { get; set; }
        /// <summary>
        /// Omgerekende hoeveelheid
        /// </summary>
        decimal GnMomH { get; set; }
        /// <summary>
        /// Eenh omgerekende hoeveelheid kode
        /// </summary>
        short XnMomE { get; set; }
        /// <summary>
        /// Basiseenheid product kode
        /// </summary>
        short XpEhHv { get; set; }
    }
}
