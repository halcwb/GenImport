using System;
using System.Collections.Generic;
using Informedica.GenForm.DomainModel.Interfaces;

namespace Informedica.GenImport.Library.DomainModel.Product
{
    public class UnitGroup : IUnitGroup
    {
        public Guid Id
        {
            get { throw new NotImplementedException(); }
        }

        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public bool AllowsConversion
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<IUnit> Units
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<IShape> Shapes
        {
            get { throw new NotImplementedException(); }
        }

        public void AddUnit(IUnit unit)
        {
            throw new NotImplementedException();
        }

        public void AddShape(IShape shape)
        {
            throw new NotImplementedException();
        }

        public void RemoveShape(IShape shape)
        {
            throw new NotImplementedException();
        }
    }
}
