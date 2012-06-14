using System;
using Informedica.GenForm.DomainModel.Interfaces;

namespace Informedica.GenImport.Library.DomainModel.Product
{
    public class UnitValue : IUnitValue
    {
        public IUnit Unit
        {
            get { throw new NotImplementedException(); }
        }

        public decimal Value
        {
            get { throw new NotImplementedException(); }
        }
    }
}
