using System;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.EntityRepository.Entities;
using Informedica.GenImport.GStandard.Attributes;

namespace Informedica.GenImport.GStandard.DomainModel
{
    public class Naam : INaam, IEntity<Naam, int>
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

        #region Implementation of IEntity<in Naam,out int>

        public virtual int Id
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsIdentical(Naam entity)
        {
            throw new NotImplementedException();
        }

        public bool IsTransient()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
