using Informedica.GenImport.Library.DomainModel.GStandard;

namespace Informedica.GenImport.Library.DomainModel.Interfaces
{
    public interface IRelatieTussenNaam : IGStandardModel
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
