using Informedica.GenForm.DomainModel.Interfaces;

namespace Informedica.GenImport.Library.DomainModel.Product
{
    public class Package : IPackage
    {
        public System.Guid Id
        {
            get { throw new System.NotImplementedException(); }
        }

        public string Name
        {
            get { throw new System.NotImplementedException(); }
        }

        public string Abbreviation
        {
            get { throw new System.NotImplementedException(); }
        }

        public System.Collections.Generic.IEnumerable<IProduct> Products
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}
