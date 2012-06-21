using Informedica.GenImport.Library.Attributes;
using Informedica.GenImport.Library.DomainModel.Interfaces;

namespace Informedica.GenImport.Library.DomainModel.GStandard
{
    public class ThesauriTotaal : IThesauriTotaal
    {
        [FileLinePosition(5, 5)]
        public MutKod MutKod { get; set; }

        [FileLinePosition(6, 9)]
        public int TsNr { get; set; }

        [FileLinePosition(10, 15)]
        public int TsItNr { get; set; }

        [FileLinePosition(16, 17)]
        public string ThItMk { get; set; }

        [FileLinePosition(18, 21)]
        public string ThNm4 { get; set; }

        [FileLinePosition(22, 36)]
        public string ThNm15 { get; set; }

        [FileLinePosition(37, 61)]
        public string ThNm25 { get; set; }

        [FileLinePosition(62, 111)]
        public string ThNm50 { get; set; }

        [FileLinePosition(112, 112)]
        public string ThAKd1 { get; set; }
        
        [FileLinePosition(113, 113)]
        public string ThAKd2 { get; set; }

        [FileLinePosition(114, 114)]
        public string ThAKd3 { get; set; }

        [FileLinePosition(115, 115)]
        public string ThAKd4 { get; set; }

        [FileLinePosition(116, 116)]
        public string ThAKd5 { get; set; }

        [FileLinePosition(117, 117)]
        public string ThAKd6 { get; set; }
    }
}
