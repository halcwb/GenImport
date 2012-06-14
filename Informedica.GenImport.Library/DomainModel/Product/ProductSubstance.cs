using System;
using Informedica.GenForm.DomainModel.Interfaces;

namespace Informedica.GenImport.Library.DomainModel.Product
{
    public class ProductSubstance : IProductSubstance
    {
        public Guid Id
        {
            get { throw new NotImplementedException(); }
        }

        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public int SortOrder
        {
            get { throw new NotImplementedException(); }
        }

        public ISubstance Substance
        {
            get { throw new NotImplementedException(); }
        }

        public IUnitValue Quantity
        {
            get { throw new NotImplementedException(); }
        }
    }
}
