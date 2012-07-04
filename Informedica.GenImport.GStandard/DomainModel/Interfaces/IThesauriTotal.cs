using Informedica.GenImport.GStandard.DomainModel.Enums;

namespace Informedica.GenImport.GStandard.DomainModel.Interfaces
{
    /// <summary>
    /// Contract for a line in G-Standard file 902.
    /// </summary>
    public interface IThesauriTotal : IGStandardModel
    {
        /// <summary>
        /// Mutatiekode
        /// </summary>
        MutKod MutKod { get; set; }
        /// <summary>
        /// Thesaurusnummer (in nieuwe thesauri)
        /// </summary>
        short TsNr { get; set; }
        /// <summary>
        /// Thesaurus itemnummer (in nieuwe thesauri)
        /// </summary>
        int TsItNr { get; set; }
        /// <summary>
        /// Memokode item
        /// </summary>
        string ThItMk { get; set; }
        /// <summary>
        /// Naam item 4 posities
        /// </summary>
        string ThNm4 { get; set; }
        /// <summary>
        /// Naam item 15 posities
        /// </summary>
        string ThNm15 { get; set; }
        /// <summary>
        /// Naam item 25 posities
        /// </summary>
        string ThNm25 { get; set; }
        /// <summary>
        /// Naam item 50 posities
        /// </summary>
        string ThNm50 { get; set; }
        /// <summary>
        /// Aanvullende kode 1
        /// </summary>
        string ThAKd1 { get; set; }
        /// <summary>
        /// Aanvullende kode 2
        /// </summary>
        string ThAKd2 { get; set; }
        /// <summary>
        /// Aanvullende kode 3
        /// </summary>
        string ThAKd3 { get; set; }
        /// <summary>
        /// Aanvullende kode 4
        /// </summary>
        string ThAKd4 { get; set; }
        /// <summary>
        /// Aanvullende kode 5
        /// </summary>
        string ThAKd5 { get; set; }
        /// <summary>
        /// Aanvullende kode 6
        /// </summary>
        string ThAKd6 { get; set; }
    }
}
