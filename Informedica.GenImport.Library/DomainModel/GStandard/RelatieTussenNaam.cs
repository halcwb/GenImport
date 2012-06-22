using Informedica.GenImport.Library.Attributes;
using Informedica.GenImport.Library.DomainModel.Interfaces;

namespace Informedica.GenImport.Library.DomainModel.GStandard
{
    public class RelatieTussenNaam : IRelatieTussenNaam
    {
        [FileLinePosition(5,5)]
        public virtual MutKod MutKod { get; set; }

        [FileLinePosition(6,8)]
        public virtual int NmRNr { get; set; }

        [FileLinePosition(9, 15)]
        public virtual int NmNrIn { get; set; }

        [FileLinePosition(16,22)]
        public virtual int NmNrUit { get; set; }
    }
}
