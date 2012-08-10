using System;
using System.Collections.Generic;
using Informedica.GenImport.Library.DomainModel.Product;
using Informedica.GenImport.Library.Services;

namespace Informedica.GenImport.Wcf
{
    public class WcfService : IWcfService
    {
        private readonly IDataService _dataService;

        public WcfService(IDataService dataService)
        {
            _dataService = dataService;
        }

        #region Implementation of IWcfService

        public List<Product> GetProductsByProductCode(int productCode)
        {
            return _dataService.GetProductsByProductCode(productCode);
        }

        public void RefreshDatabase()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
