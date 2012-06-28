using Informedica.GenImport.GStandard.Attributes;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel
{
    public class GeneriekeNaam : IGeneriekeNaam
    {
        #region Implementation of IGeneriekeNaam

        /// <summary>
        /// Mutatiekode
        /// </summary>
        [FileLinePosition(5, 5)]
        public MutKod MutKod { get; set; }

        /// <summary>
        /// GeneriekeNaamKode (GNK)
        /// </summary>
        [FileLinePosition(6, 11)]
        [Modulo11]
        public int GnGnK { get; set; }

        /// <summary>
        /// Generieke naam
        /// </summary>
        [FileLinePosition(12, 61)]
        public string GnGnAm { get; set; }

        #endregion
    }
}
