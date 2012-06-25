using Informedica.GenImport.Library.Attributes;
using Informedica.GenImport.Library.DomainModel.Interfaces;

namespace Informedica.GenImport.Library.DomainModel.GStandard
{
    public class Samenstelling : ISamenstelling
    {
        [FileLinePosition(5, 5)]
        public MutKod MutKod { get; set; }
        [FileLinePosition(6, 9)]
        public int ThsrTc { get; set; }
        [FileLinePosition(10, 15)]
        public int SrtCde { get; set; }
        [FileLinePosition(16, 23)]
        public int Code { get; set; }
        [FileLinePosition(24, 29)]
        [Modulo11]
        public int GnGnK { get; set; }
        [DecimalFormat(3)]
        [FileLinePosition(30, 41)]
        public decimal GnHoev { get; set; }
        [FileLinePosition(42, 45)]
        public int TsGneH { get; set; }
        [FileLinePosition(46, 51)]
        public int GnEenh { get; set; }
        [FileLinePosition(52, 57)]
        [Modulo11]
        public int GnStam { get; set; }
        [DecimalFormat(3)]
        [FileLinePosition(58, 69)]
        public decimal StHoev { get; set; }
        [FileLinePosition(70, 73)]
        public int TsStEh { get; set; }
        [FileLinePosition(74, 79)]
        public int StEenh { get; set; }
        [BooleanFormat("J", "N")]
        [FileLinePosition(80, 80)]
        public bool StAdd { get; set; }
    }
}
