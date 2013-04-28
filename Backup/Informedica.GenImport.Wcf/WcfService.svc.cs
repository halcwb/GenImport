using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Informedica.GenImport.Library.DomainModel.Product;
using Informedica.GenImport.Library.Services;

namespace Informedica.GenImport.Wcf
{
    public class WcfService : IWcfService
    {
        private readonly IDataService _dataService;
        private readonly IImportService _importService;

        public WcfService(IDataService dataService, IImportService importService)
        {
            Contract.Requires<ArgumentNullException>(dataService != null, "dataService");
            Contract.Requires<ArgumentNullException>(importService != null, "importService");

            _dataService = dataService;
            _importService = importService;
        }

        #region Implementation of IWcfService

        public List<Product> FindProductsByName(string name)
        {
            return _dataService.FindProductsByName(name).ToList();
        }

        public int GetProductCount()
        {
            return _dataService.GetProductCount();
        }

        public List<Product> GetProductsByProductCode(int productCode)
        {
            return _dataService.GetProductsByProductCode(productCode).ToList();
        }

        public void RefreshDatabase()
        {
            var source = new CancellationTokenSource();
            CancellationToken token = source.Token;

            Task.Factory.StartNew(() => _importService.Start(token), token);
        }

        #endregion
    }
}
