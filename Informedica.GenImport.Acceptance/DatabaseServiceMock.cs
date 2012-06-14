using System;
using System.Collections.Generic;
using Informedica.GenImport.DataAccess;
using Informedica.GenImport.Library.DomainModel.Product;
using Moq;
using System.Linq;

namespace Informedica.GenImport.Acceptance
{
    public class DatabaseServiceMock
    {
        private readonly Mock<IDatabaseService> _mockDatabaseService;
        public IDatabaseService DatabaseService
        {
            get
            {
                return _mockDatabaseService.Object;
            }
        }

        public DatabaseServiceMock()
        {
            _mockDatabaseService = new Mock<IDatabaseService>(MockBehavior.Strict);
        }

        public void SetProductsToBeReturned(IEnumerable<Product> products)
        {
            _mockDatabaseService.Setup(s => s.GetProducts()).Returns(products);
            //_mockDatabaseService.Setup(s => s.ProductExists(It.IsAny<string>())).Returns(name=> products.Any(p=>p.GenericName == name));
        }

        public void SetProductExistsToBeReturned(string productToExistName, bool productExists)
        {
            
        }

        public void SetUpdateProductThrowsInvalidOperationException(Product product)
        {
            _mockDatabaseService.Setup(s => s.UpdateProduct(product)).Throws(new InvalidOperationException());
        }
    }
}
