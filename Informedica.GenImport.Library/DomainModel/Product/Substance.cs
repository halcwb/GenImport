using System;
using System.Collections.Generic;
using Informedica.GenForm.DomainModel.Interfaces;

namespace Informedica.GenImport.Library.DomainModel.Product
{
    public class Substance : ISubstance
    {
        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public ISubstanceGroup SubstanceGroup
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<IProduct> Products
        {
            get { throw new NotImplementedException(); }
        }

        public void SetSubstanceGroup(ISubstanceGroup group)
        {
            throw new NotImplementedException();
        }

        public void RemoveFromSubstanceGroup()
        {
            throw new NotImplementedException();
        }

        public void AddProduct(IProduct product)
        {
            throw new NotImplementedException();
        }
    }
}
