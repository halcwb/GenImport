﻿namespace Informedica.GenImport.Library.DomainModel.GStandard.Interfaces
{
    public interface IArtikel : IGStandardModel
    {
        /// <summary>
        /// 
        /// </summary>
        int HpKode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        int AtNmNr { get; set; }
    }
}