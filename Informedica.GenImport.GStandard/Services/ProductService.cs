using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Repositories;
using Informedica.GenImport.Library.DomainModel.Product;
using Informedica.GenImport.Library.Exceptions;
using Informedica.GenImport.Library.Services;

namespace Informedica.GenImport.GStandard.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<ICommercialProduct> _commercialProductRepository;
        private readonly IRepository<IName> _nameRepository;
        private readonly IRepository<IProduct> _productRepository;

        public ProductService(IRepository<ICommercialProduct> commercialProductRepository, IRepository<IName> nameRepository, IRepository<IProduct> productRepository)
        {
            _commercialProductRepository = commercialProductRepository;
            _nameRepository = nameRepository;
            _productRepository = productRepository;
        }

        #region Implementation of IProductService

        public List<Product> GetProductsByProductCode(int productCode)
        {
            IEnumerable<IProduct> products = _productRepository.Where(i => i.HpKode == productCode);

            List<Product> result = products.Select(p =>
                                                   {
                                                       IName productName = GetName(p.AtNmNr);
                                                       return new Product{
                                                                             Name = productName.NmNaam,
                                                                             ProductCode = p.HpKode,
                                                                         };
                                                   }
                ).ToList();


            

            return result;
        }

        #endregion

        private IName GetName(int id)
        {
            IName name = _nameRepository.GetById(id);
            if(name == null)
            {
                throw new ProductIncompleteException(string.Format(CultureInfo.InvariantCulture, "Name with id {0} could not be found.", id));
            }
            return name;
        }
    }
}
