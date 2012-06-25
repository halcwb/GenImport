using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Attributes;

namespace Informedica.GenImport.GStandard.DomainModel
{
    public class Artikel : IArtikel
    {
        [FileLinePosition(5, 5)]
        public virtual MutKod MutKod { get; set; }

        [FileLinePosition(6, 13)]
        [Modulo11]
        public virtual int AtKode { get; set; }
        
        [FileLinePosition(14, 21)]
        [Modulo11]
        public virtual int HpKode { get; set; }

        [FileLinePosition(22, 28)]
        public virtual int AtNmNr { get; set; }
    }
}
