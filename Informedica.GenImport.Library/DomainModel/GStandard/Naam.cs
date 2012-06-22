using Informedica.GenImport.Library.Attributes;
using Informedica.GenImport.Library.DomainModel.Interfaces;

namespace Informedica.GenImport.Library.DomainModel.GStandard
{
    public class Naam : INaam
    {
        [FileLinePosition(5, 5)]
        public virtual MutKod MutKod { get; set; }

        [FileLinePosition(6, 12)]
        public virtual int NmNr { get; set; }

        [FileLinePosition(13, 18)]
        public virtual string NmMemo { get; set; }

        [FileLinePosition(19, 45)]
        public virtual string NmEtiket { get; set; }

        [FileLinePosition(46, 85)]
        public virtual string NmNm40 { get; set; }

        [FileLinePosition(86, 135)]
        public virtual string NmNaam { get; set; }
    }
}
