namespace Informedica.GenImport.GStandard.DomainModel.Interfaces
{
    public interface ISamenstelling : IGStandardModel
    {
        /// <summary>
        /// Mutatiekode
        /// </summary>
        MutKod MutKod { get; set; }
        /// <summary>
        /// Thesaurus verwijzing soort code
        /// </summary>
        int ThsrTc { get; set; }
        /// <summary>
        /// Soort code
        /// </summary>
        int SrtCde { get; set; }
        /// <summary>
        /// Code
        /// </summary>
        int Code { get; set; }
        /// <summary>
        /// GeneriekeNaamKode (GNK)
        /// </summary>
        int GnGnK { get; set; }
        /// <summary>
        /// Hoeveelheid generiek naam
        /// </summary>
        decimal GnHoev { get; set; }
        /// <summary>
        /// Thesaurusverwijzig eenh. hoeveelh. generiek naam
        /// </summary>
        int TsGneH { get; set; }
        /// <summary>
        /// Eenheid hoeveelheid generieke naam
        /// </summary>
        int GnEenh { get; set; }
        /// <summary>
        /// Stamnaamcode (SNK)
        /// </summary>
        int GnStam { get; set; }
        /// <summary>
        /// Hoeveelheid stamnaam
        /// </summary>
        decimal StHoev { get; set; }
        /// <summary>
        /// Thesaurusverwijzig eenh. hoeveelh. stamnaam
        /// </summary>
        int TsStEh { get; set; }
        /// <summary>
        /// Eenheid hoeveelheid stamnaam
        /// </summary>
        int StEenh { get; set; }
        /// <summary>
        /// Sterktes mogen worden opgeteld J/N
        /// </summary>
        bool StAdd { get; set; }
    }
}
