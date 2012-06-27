using Informedica.GenImport.GStandard.DomainModel.Enums;

namespace Informedica.GenImport.GStandard.DomainModel.Interfaces
{
    /// <summary>
    /// Contract for a line in G-Standard file 711.
    /// </summary>
    public interface IGeneriekProduct : IGStandardModel
    {
        /// <summary>
        /// Mutatiekode
        /// </summary>
        MutKod MutKod { get; set; }
        /// <summary>
        /// Generiekeproductcode (GPK)
        /// </summary>
        int GpKode { get; set; }
        /// <summary>
        /// GSK-code
        /// </summary>
        int GsKode { get; set; }
        /// <summary>
        /// Farmaceutische vorm thesaurusnummer
        /// </summary>
        short ThKtVr { get; set; }
        /// <summary>
        /// Farmaceutische vorm code
        /// </summary>
        short GpKtVr { get; set; }
        /// <summary>
        /// Toedieningsweg thesaurusnummer
        /// </summary>
        short ThKTwg { get; set; }
        /// <summary>
        /// Toedieningsweg code
        /// </summary>
        short GpKTwg { get; set; }
        /// <summary>
        /// Naamnummer volledige GPK-naam
        /// </summary>
        int GpNmNr { get; set; }
        /// <summary>
        /// Naamnummer GPK-stofnaam
        /// </summary>
        int GpStNr { get; set; }
        /// <summary>
        /// Ingegeven sterkte stofnamen
        /// </summary>
        string GpInSt { get; set; }

        /// <summary>
        /// SuperProduktKode (SPK)
        /// </summary>
        int SpKode { get; set; }
        
        /// <summary>
        /// Basiseenheid product thesaurusnr
        /// </summary>
        short ThEhHv { get; set; }
        /// <summary>
        /// Basiseenheid product kode
        /// </summary>
        short XpEhHv { get; set; }
    }
}
