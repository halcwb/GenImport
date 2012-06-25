using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Attributes;

namespace Informedica.GenImport.GStandard.DomainModel
{
    public class ThesauriTotaal : IThesauriTotaal
    {
        [FileLinePosition(5, 5)]
        public virtual MutKod MutKod { get; set; }

        [FileLinePosition(6, 9)]
        public virtual int TsNr { get; set; }

        [FileLinePosition(10, 15)]
        public virtual int TsItNr { get; set; }

        [FileLinePosition(16, 17)]
        public virtual string ThItMk { get; set; }

        [FileLinePosition(18, 21)]
        public virtual string ThNm4 { get; set; }

        [FileLinePosition(22, 36)]
        public virtual string ThNm15 { get; set; }

        [FileLinePosition(37, 61)]
        public virtual string ThNm25 { get; set; }

        [FileLinePosition(62, 111)]
        public virtual string ThNm50 { get; set; }

        [FileLinePosition(112, 112)]
        public virtual string ThAKd1 { get; set; }
        
        [FileLinePosition(113, 113)]
        public virtual string ThAKd2 { get; set; }

        [FileLinePosition(114, 114)]
        public virtual string ThAKd3 { get; set; }

        [FileLinePosition(115, 115)]
        public virtual string ThAKd4 { get; set; }

        [FileLinePosition(116, 116)]
        public virtual string ThAKd5 { get; set; }

        [FileLinePosition(117, 117)]
        public virtual string ThAKd6 { get; set; }
    }
}
