﻿using Informedica.GenImport.GStandard.DomainModel.Enums;

namespace Informedica.GenImport.GStandard.DomainModel.Interfaces
{
    /// <summary>
    /// Contract for a line in G-Standard file 750.
    /// </summary>
    public interface IGenericName : IGStandardModel<IGenericName>, ICopyable<IGenericName>
    {
        /// <summary>
        /// Mutatiekode
        /// </summary>
        MutKod MutKod { get; set; }
        /// <summary>
        /// GeneriekeNaamKode (GNK)
        /// </summary>
        int GnGnK { get; set; }
        /// <summary>
        /// Generieke naam
        /// </summary>
        string GnGnAm { get; set; }
    }
}
