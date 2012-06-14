using System;
using System.Collections.Generic;
using Informedica.GenForm.DomainModel.Interfaces;

namespace Informedica.GenImport.Library.DomainModel.Product
{
    public class Shape : IShape
    {
        public Guid Id
        {
            get { throw new NotImplementedException(); }
        }

        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<IProduct> Products
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<IPackage> Packages
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<IUnitGroup> UnitGroups
        {
            get { throw new NotImplementedException(); }
        }
    }
}
