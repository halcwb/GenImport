using System.Collections.Generic;
using Informedica.GenImport.Library.DomainModel.Product;

namespace Informedica.GenImport.Library.Services
{
    public interface IProductService
    {
        List<Product> GetProductsByProductCode(int productCode);

        //IEnumerable<Product> GetProductsByBrand(Brand brand);
        //IEnumerable<Product> GetProductsByPackage(Package package);
        //IEnumerable<Product> GetProductsByShape(Shape shape);
        //IEnumerable<Product> GetProductsBySubstance(Substance substance);
    }
}
