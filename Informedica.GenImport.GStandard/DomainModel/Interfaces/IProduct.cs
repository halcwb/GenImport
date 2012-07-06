using Informedica.EntityRepository.Entities;
using Informedica.GenImport.GStandard.DomainModel.Enums;

namespace Informedica.GenImport.GStandard.DomainModel.Interfaces
{
    /// <summary>
    /// Contract for a line in G-Standard file 004.
    /// </summary>
    public interface IProduct : IGStandardModel<IProduct>
    {
        /// <summary>
        /// Mutatiekode
        /// </summary>
        MutKod MutKod { get; set; }
        /// <summary>
        /// ZI-nummer
        /// </summary>
        int AtKode { get; set; }
        /// <summary>
        /// HandelsProduktKode
        /// </summary>
        int HpKode { get; set; }
        /// <summary>
        /// Artikelnaamnummer
        /// </summary>
        int AtNmNr { get; set; }
    }
}
