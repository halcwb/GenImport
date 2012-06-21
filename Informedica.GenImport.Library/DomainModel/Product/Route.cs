using System;
using System.Collections.Generic;
using Informedica.GenForm.DomainModel.Interfaces;

namespace Informedica.GenImport.Library.DomainModel.Product
{
    public class Route : IRoute
    {
        public Guid Id
        {
            get { throw new NotImplementedException(); }
        }

        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public string Abbreviation
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public IEnumerable<IShape> Shapes
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<IProduct> Products
        {
            get { throw new NotImplementedException(); }
        }

        public void AddShape(IShape shape)
        {
            throw new NotImplementedException();
        }

        public void RemoveShape(IShape shape)
        {
            throw new NotImplementedException();
        }

        public void AddProduct(IProduct product)
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(IProduct product)
        {
            throw new NotImplementedException();
        }
    }
}
