using System;
using Informedica.GenImport.Library.DomainModel.GStandard.Interfaces;

namespace Informedica.GenImport.Library.DomainModel.GStandard
{
    public class Naam : INaam
    {
        public MutKod MutKod { get; set; }

        public int NmNr { get; set; }

        public string NmEtiket { get; set; }

        public string NmNm40 { get; set; }

        public string NmNaam { get; set; }
    }
}
