using Informedica.EntityRepository.Entities;
using Informedica.GenImport.GStandard.DomainModel.Enums;

namespace Informedica.GenImport.GStandard.DomainModel.Interfaces
{
    /// <summary>
    /// Contract for a line in G-Standard file 020.
    /// </summary>
    public interface IName : IGStandardModel<IName>, ICopyable<IName>
    {
        /// <summary>
        /// Mutatiekode
        /// </summary>
        MutKod MutKod { get; set; }
        /// <summary>
        /// Naamnummer
        /// </summary>
        int NmNr { get; set; }
        /// <summary>
        /// Memokode
        /// </summary>
        string NmMemo { get; set; }
        /// <summary>
        /// Etiketnaam
        /// </summary>
        string NmEtiket { get; set; }
        /// <summary>
        /// Korte handelsnaam
        /// </summary>
        string NmNm40 { get; set; }
        /// <summary>
        /// Naam volledig
        /// </summary>
        string NmNaam { get; set; }
    }
}
