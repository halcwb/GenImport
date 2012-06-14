using System.Collections.Generic;
using Informedica.GenImport.Library.DomainModel.Product;

namespace Informedica.GenImport.DataAccess
{
    public interface IDatabaseService
    {
        IEnumerable<Product> GetProducts();
        bool ProductExists(string productName);
        void UpdateProduct(Product product);
    }
}
