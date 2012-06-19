using System;
using Informedica.GenForm.DomainModel.Interfaces;

namespace Informedica.GenImport.Library.DomainModel.Product
{
    public class Product : IProduct
    {
        public Guid Id
        {
            get { throw new NotImplementedException(); }
        }

        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public string ProductCode { get; set; }

        public string GenericName
        {
            get { throw new NotImplementedException(); }
        }

        public IBrand Brand
        {
            get { throw new NotImplementedException(); }
        }

        public IShape Shape
        {
            get { throw new NotImplementedException(); }
        }

        public IUnitValue Quantity
        {
            get { throw new NotImplementedException(); }
        }

        public IPackage Package
        {
            get { throw new NotImplementedException(); }
        }

        public string DisplayName
        {
            get { throw new NotImplementedException(); }
        }

        public System.Collections.Generic.IEnumerable<IProductSubstance> Substances
        {
            get { throw new NotImplementedException(); }
        }

        public bool ContainsSubstance(ISubstance substance)
        {
            throw new NotImplementedException();
        }

        public void AddSubstance(ISubstance substance, int sortOrder, IUnitValue quanity)
        {
            throw new NotImplementedException();
        }

        public void RemoveSubstance(ISubstance substance)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<IRoute> Routes
        {
            get { throw new NotImplementedException(); }
        }

        public bool ContainsRoute(IRoute route)
        {
            throw new NotImplementedException();
        }

        public void AddRoute(IRoute route)
        {
            throw new NotImplementedException();
        }

        public void RemoveRoute(IRoute route)
        {
            throw new NotImplementedException();
        }
    }
}
