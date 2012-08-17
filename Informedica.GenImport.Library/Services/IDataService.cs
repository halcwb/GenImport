using System.Collections.Generic;
using Informedica.GenImport.Library.DomainModel.Product;

namespace Informedica.GenImport.Library.Services
{
    public interface IDataService
    {
        IEnumerable<Product> FindProductsByName(string name);
        int GetProductCount();
        IEnumerable<Product> GetProductsByProductCode(int productCode);
    }
}
