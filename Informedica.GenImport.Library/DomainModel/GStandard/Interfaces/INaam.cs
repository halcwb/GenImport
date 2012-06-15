namespace Informedica.GenImport.Library.DomainModel.GStandard.Interfaces
{
    public interface INaam : IGStandardModel
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
