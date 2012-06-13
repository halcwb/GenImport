using System.Collections.Generic;

namespace Informedica.GenImport
{
    public interface IDatabaseService
    {
        IEnumerable<Product> GetProducts();
        bool ProductExists(string productName);
        void UpdateProduct(Product product);
    }
}
