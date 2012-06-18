using Informedica.GenImport.Library.DomainModel.GStandard;

namespace Informedica.GenImport.Library.DomainModel.Interfaces
{
    public interface IArtikel : IGStandardModel
    {
        /// <summary>
        /// Mutatiekode
        /// </summary>
        MutKod MutKod { get; set; }
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
