using Informedica.GenImport.GStandard.DomainModel.Enums;

namespace Informedica.GenImport.GStandard.DomainModel.Interfaces
{
    /// <summary>
    /// Contract for a line in G-Standard file 025.
    /// </summary>
    public interface IRelationBetweenName : IGStandardModel
    {
        /// <summary>
        /// Mutatiekode
        /// </summary>
        MutKod MutKod { get; set; }
        /// <summary>
        /// Relatie soort
        /// </summary>
        int NmRNr { get; set; }
        /// <summary>
        /// Naamnummer ingang
        /// </summary>
        int NmNrIn { get; set; }
        /// <summary>
        /// Naamnummer uitgang
        /// </summary>
        int NmNrUit { get; set; }
    }
}
