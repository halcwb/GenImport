using Informedica.GenImport.Library.Attributes;
using Informedica.GenImport.Library.DomainModel.Interfaces;

namespace Informedica.GenImport.Library.DomainModel.GStandard
{
    public class Artikel : IArtikel
    {
        [FileLinePosition(5, 5)]
        public MutKod MutKod { get; set; }

        [FileLinePosition(6, 13)]
        [Modulo11]
        public int AtKode { get; set; }
        
        [FileLinePosition(14, 21)]
        [Modulo11]
        public int HpKode { get; set; }

        [FileLinePosition(22, 28)]
        public int AtNmNr { get; set; }
    }
}
