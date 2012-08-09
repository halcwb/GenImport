using System;
using System.Collections.Generic;
using Informedica.GenImport.Library.DomainModel.Product;
using Informedica.GenImport.Library.Services;

namespace Informedica.GenImport.Wcf
{
    public class WcfService : IWcfService
    {
        private readonly IProductService _productService;

        public WcfService(IProductService productService)
        {
            _productService = productService;
        }

        #region Implementation of IWcfService

        public List<Product> GetProductsByProductCode(int productCode)
        {
            return _productService.GetProductsByProductCode(productCode);
        }

        public void RefreshDatabase()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
