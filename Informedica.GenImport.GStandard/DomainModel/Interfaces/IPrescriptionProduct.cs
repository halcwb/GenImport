using Informedica.GenImport.GStandard.DomainModel.Enums;

namespace Informedica.GenImport.GStandard.DomainModel.Interfaces
{
    /// <summary>
    /// Contract for a line in G-Standard file 050.
    /// </summary>
    public interface IPrescriptionProduct : IGStandardModel
    {
        /// <summary>
        /// Mutatiekode
        /// </summary>
        MutKod MutKod { get; set; }
        /// <summary>
        /// PRK-code
        /// </summary>
        int PrKode { get; set; }
        /// <summary>
        /// Naamnummer prescriptie product
        /// </summary>
        int PrNmNr { get; set; }
    }
}
