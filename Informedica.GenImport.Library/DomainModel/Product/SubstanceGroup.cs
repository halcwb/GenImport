using System;
using System.Collections.Generic;
using Informedica.GenForm.DomainModel.Interfaces;

namespace Informedica.GenImport.Library.DomainModel.Product
{
    public class SubstanceGroup : ISubstanceGroup
    {
        public Guid Id
        {
            get { throw new NotImplementedException(); }
        }

        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public ISubstanceGroup MainSubstanceGroup
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public IEnumerable<ISubstance> Substances
        {
            get { throw new NotImplementedException(); }
        }

        public bool ContainsSubstance(ISubstance subst)
        {
            throw new NotImplementedException();
        }

        public void AddSubstance(ISubstance substance)
        {
            throw new NotImplementedException();
        }

        public void Remove(ISubstance substance)
        {
            throw new NotImplementedException();
        }

        public void ClearAllSubstances()
        {
            throw new NotImplementedException();
        }
    }
}
