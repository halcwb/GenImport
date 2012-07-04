using Informedica.GenImport.GStandard.Attributes;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;

namespace Informedica.GenImport.GStandard.DomainModel
{
    public class Product : IProduct
    {
        #region Implementation of IArtikel

        /// <summary>
        /// Mutatiekode
        /// </summary>
        [FileLinePosition(5, 5)]
        public virtual MutKod MutKod { get; set; }

        /// <summary>
        /// ZI-nummer
        /// </summary>
        [FileLinePosition(6, 13)]
        [Modulo11]
        public virtual int AtKode { get; set; }

        /// <summary>
        /// HandelsProduktKode
        /// </summary>
        [FileLinePosition(14, 21)]
        [Modulo11]
        public virtual int HpKode { get; set; }

        /// <summary>
        /// Artikelnaamnummer
        /// </summary>
        [FileLinePosition(22, 28)]
        public virtual int AtNmNr { get; set; }

        #endregion
    }
}