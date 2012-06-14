using System;
using Informedica.GenForm.DomainModel.Interfaces;

namespace Informedica.GenImport.Library.DomainModel.Product
{
    public class Unit : IUnit
    {
        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public IUnitGroup UnitGroup
        {
            get { throw new NotImplementedException(); }
        }

        public string Abbreviation
        {
            get { throw new NotImplementedException(); }
        }

        public decimal Multiplier
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsReference
        {
            get { throw new NotImplementedException(); }
        }
    }
}
