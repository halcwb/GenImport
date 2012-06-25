namespace Informedica.GenImport.GStandard.DomainModel.Interfaces
{
    public interface IArtikel : IGStandardModel
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
