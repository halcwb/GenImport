using System.Collections.Generic;
using Informedica.GenImport.DataAccess.Model;

namespace Informedica.GenImport
{
    public interface IDatabaseService
    {
        IEnumerable<Product> GetProducts();
        bool ProductExists(string productName);
        void UpdateProduct(Product product);
    }
}
