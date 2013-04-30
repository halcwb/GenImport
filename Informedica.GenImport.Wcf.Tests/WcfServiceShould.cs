using System;
using System.Collections.Generic;
using System.Threading;
using Informedica.GenImport.Library.DomainModel.Product;
using Informedica.GenImport.Library.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TypeMock;
using TypeMock.ArrangeActAssert;

namespace Informedica.GenImport.Wcf.Tests
{
    [TestClass]
    public class WcfServiceShould
    {
        private static IDataService GetDataServiceMock(List<Product> products)
        {
            var dataServiceMock = new Moq.Mock<IDataService>(MockBehavior.Strict);
            dataServiceMock.Setup(s => s.GetProductsByProductCode(It.IsAny<int>())).Returns(products);

            return dataServiceMock.Object;
        }
        
        private static IImportService GetImportServiceMock(Action<MethodCallContext> startAction)
        {
            var productRepositoryMock = Isolate.Fake.Instance<IImportService>();
            Isolate.WhenCalled(() => productRepositoryMock.Start(new CancellationToken())).DoInstead(startAction);

            //var importServiceMock = new Mock<>();
            
            //var importServiceMock = new Mock<IImportService>(MockBehavior.Strict);
            //importServiceMock.Setup(s => s.Start(It.IsAny<CancellationToken>())).Callback(startAction);

            //return importServiceMock.Object;
            return productRepositoryMock;
        }

        [TestMethod]
        public void Start_Import_Of_GStandard_When_RefreshDatabase_Is_Called()
        {
            bool started = false;
            //var importService = GetImportServiceMock(x => started = true);
            //var dataService = GetDataServiceMock(null);
            Bootstrapper.ConfigureStructureMap();
            var wcfService = new WcfService();

            wcfService.RefreshDatabase();
            
            Assert.IsTrue(started);
        }
    }
}
