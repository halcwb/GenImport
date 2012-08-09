using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Repositories;
using Informedica.GenImport.GStandard.Services;
using Informedica.GenImport.Library.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Informedica.GenImport.GStandard.Tests.Services
{
    [TestClass]
    public class ProductServiceShould
    {
        #region Helpers

        private static IRepository<IName> GetNameRepositoryMock(IEnumerable<IName> names)
        {
            Mock<IRepository<IName>> nameRepositoryMock = new Mock<IRepository<IName>>(MockBehavior.Strict);
            nameRepositoryMock.Setup(s => s.GetById(It.IsAny<int>())).Returns((int id) => names.SingleOrDefault(n => n.Id == id));
            return nameRepositoryMock.Object;
        }

        private static IRepository<IProduct> GetProductRepositoryMock(IEnumerable<IProduct> products)
        {
            Mock<IRepository<IProduct>> productRepositoryMock = new Mock<IRepository<IProduct>>(MockBehavior.Strict);
            productRepositoryMock.Setup(s => s.Where(It.IsAny<Func<IProduct, bool>>())).Returns(products);
            return productRepositoryMock.Object;
        }

        #endregion


        [TestMethod]
        [ExpectedException(typeof(ProductIncompleteException))]
        public void Throw_An_IncompleteProductException_On_GetProductsByProductCode_When_A_Product_Name_Is_Missing()
        {
            IEnumerable<IProduct> products = new List<IProduct>{
                                                             new Product{
                                                                            AtKode = 1,
                                                                            AtNmNr = 1,
                                                                            HpKode = 1,
                                                                            MutKod = MutKod.RecordNotChanged
                                                                        }
                                                         };
            IEnumerable<IName> names = new List<IName>();
            var productRepository = GetProductRepositoryMock(products);
            var nameRepository = GetNameRepositoryMock(names);

            var service = new ProductService(null, nameRepository, productRepository);

            service.GetProductsByProductCode(1);
        }
    }
}
