using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Informedica.GenImport.Library.DomainModel.Interfaces;

namespace Informedica.GenImport.Library.DomainModel.GStandard
{
    public class Samenstelling : ISamenstelling
    {
        public MutKod MutKod { get; set; }
        public int ThsrTc { get; set; }
        public int SrtCde { get; set; }
        public int Code { get; set; }
        public int GnGnK { get; set; }
        public decimal GnHoev { get; set; }
        public int TsGneH { get; set; }
        public int GnEenh { get; set; }
        public int GnStam { get; set; }
        public decimal StHhoev { get; set; }
        public int TsStEh { get; set; }
        public int StEenh { get; set; }
        public bool StAdd { get; set; }
    }
}
