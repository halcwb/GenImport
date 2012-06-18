using System;
using Informedica.GenImport.Library.DomainModel.Interfaces;

namespace Informedica.GenImport.Library.DomainModel.GStandard
{
    public class Artikel : IArtikel
    {
        
        public MutKod MutKod { get; set; }

        public int AtKode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public int HpKode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public int AtNmNr
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
}
