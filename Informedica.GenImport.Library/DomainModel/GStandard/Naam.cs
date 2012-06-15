using Informedica.GenImport.Library.DomainModel.GStandard.Interfaces;

namespace Informedica.GenImport.Library.DomainModel.GStandard
{
    public class Naam : INaam
    {
        [FileLinePosition(5, 5)]
        public MutKod MutKod { get; set; }
        [FileLinePosition(6, 12)]
        public int NmNr { get; set; }
        [FileLinePosition(13, 18)]
        public string NmMemo { get; set; }
        [FileLinePosition(19, 45)]
        public string NmEtiket { get; set; }
        [FileLinePosition(46, 85)]
        public string NmNm40 { get; set; }
        [FileLinePosition(86, 135)]
        public string NmNaam { get; set; }
    }
}
