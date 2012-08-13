using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.Library.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel.Interfaces
{
    /// <summary>
    /// Contract for a line in G-Standard file 031.
    /// </summary>
    public interface ICommercialProduct : IGStandardModel<ICommercialProduct>, ICopyable<ICommercialProduct>
    {
        /// <summary>
        /// Mutatiekode
        /// </summary>
        MutKod MutKod { get; set; }
        /// <summary>
        /// Handelsproduktkode
        /// </summary>
        int HpKode { get; set; }
        /// <summary>
        /// Handelsproduktnaamnummer
        /// </summary>
        int HpNamN { get; set; }
        /// <summary>
        /// Merkstamnaam
        /// </summary>
        string MsNaam { get; set; }
        /// <summary>
        /// Firmastamnaam
        /// </summary>
        string FsNaam { get; set; }
        /// <summary>
        /// Emballagemateriaal thesaurusnummer
        /// </summary>
        short TsEmbM { get; set; }
        /// <summary>
        /// Emballagemateriaal kode
        /// </summary>
        int XsEmbM { get; set; }
    }
}
