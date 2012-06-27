using Informedica.GenImport.GStandard.DomainModel.Enums;

namespace Informedica.GenImport.GStandard.DomainModel.Interfaces
{
    /// <summary>
    /// Contract for a line in G-Standard file 031.
    /// </summary>
    public interface IHandelsProduct : IGStandardModel
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
