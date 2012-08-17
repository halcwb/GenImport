using System;
using System.Collections.Generic;
using System.Linq;
using Informedica.EntityRepository.Entities;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Repositories;
using Informedica.GenImport.GStandard.Services;
using Informedica.GenImport.Library.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Informedica.GenImport.GStandard.Tests.Services
{
    [TestClass]
    public class DataServiceShould
    {
        #region Helpers

        private static IRepository<TEnt> GetRepositoryMock<TEnt>(IEnumerable<TEnt> entities)
            where TEnt : class, IEntity<TEnt, int>
        {
            Mock<IRepository<TEnt>> mock = new Mock<IRepository<TEnt>>(MockBehavior.Strict);
            mock.Setup(s => s.GetById(It.IsAny<int>())).Returns((int id) => entities.SingleOrDefault(n => n.Id == id));
            mock.Setup(s => s.GetQueryable()).Returns(entities.AsQueryable());
            return mock.Object;
        }

        #endregion

        #region Exceptions

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Throw_An_ArgumentNullException_When_Constructor_Is_Called_With_ProductComparer_Null()
        {
            var commercialProductRepository = GetRepositoryMock(new List<ICommercialProduct>());
            var nameRepository = GetRepositoryMock(new List<IName>());
            var prescriptionProductRepository = GetRepositoryMock(new List<IPrescriptionProduct>());
            var productRepository = GetRepositoryMock(new List<IProduct>());
            new DataService(null, commercialProductRepository, nameRepository, prescriptionProductRepository, productRepository);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Throw_An_ArgumentNullException_When_Constructor_Is_Called_With_CommercialProductRepository_Null()
        {
            var productComparer = new ProductComparer();
            var nameRepository = GetRepositoryMock(new List<IName>());
            var prescriptionProductRepository = GetRepositoryMock(new List<IPrescriptionProduct>());
            var productRepository = GetRepositoryMock(new List<IProduct>());
            new DataService(productComparer, null, nameRepository, prescriptionProductRepository, productRepository);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Throw_An_ArgumentNullException_When_Constructor_Is_Called_With_NameRepository_Null()
        {
            var productComparer = new ProductComparer();
            var commercialProductRepository = GetRepositoryMock(new List<ICommercialProduct>());
            var prescriptionProductRepository = GetRepositoryMock(new List<IPrescriptionProduct>());
            var productRepository = GetRepositoryMock(new List<IProduct>());
            new DataService(productComparer, commercialProductRepository, null, prescriptionProductRepository, productRepository);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Throw_An_ArgumentNullException_When_Constructor_Is_Called_With_PrescriptionProductRepository_Null()
        {
            var productComparer = new ProductComparer();
            var commercialProductRepository = GetRepositoryMock(new List<ICommercialProduct>());
            var nameRepository = GetRepositoryMock(new List<IName>());
            var productRepository = GetRepositoryMock(new List<IProduct>());
            new DataService(productComparer, commercialProductRepository, nameRepository, null, productRepository);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Throw_An_ArgumentNullException_When_Constructor_Is_Called_With_ProductRepository_Null()
        {
            var productComparer = new ProductComparer();
            var commercialProductRepository = GetRepositoryMock(new List<ICommercialProduct>());
            var prescriptionProductRepository = GetRepositoryMock(new List<IPrescriptionProduct>());
            var nameRepository = GetRepositoryMock(new List<IName>());
            new DataService(productComparer, commercialProductRepository, nameRepository, prescriptionProductRepository, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ProductIncompleteException))]
        public void Throw_An_IncompleteProductException_On_GetProductsByProductCode_When_A_Product_Name_Is_Missing()
        {
            var products = new List<IProduct>{
                                                 new Product{
                                                                AtKode = 1,
                                                                AtNmNr = 1,
                                                                HpKode = 1,
                                                                MutKod = MutKod.RecordNotChanged
                                                            }
                                             };
            var productComparer = new ProductComparer();
            var commercialProductRepository = GetRepositoryMock(new List<ICommercialProduct>());
            var nameRepository = GetRepositoryMock(new List<IName>());
            var prescriptionProductRepository = GetRepositoryMock(new List<IPrescriptionProduct>());
            var productRepository = GetRepositoryMock(products);
            var dataService = new DataService(productComparer, commercialProductRepository, nameRepository, prescriptionProductRepository, productRepository);

            dataService.GetProductsByProductCode(1);
        }

        #endregion

        [TestMethod]
        public void Return_The_Actual_Product_Count_When_GetProductCount_Is_Called()
        {
            var products = new List<IProduct>{
                                                new Product(),
                                                new Product(),
                                                new Product()
                                            };
            var productComparer = new ProductComparer();
            var commercialProductRepository = GetRepositoryMock(new List<ICommercialProduct>());
            var nameRepository = GetRepositoryMock(new List<IName>());
            var prescriptionProductRepository = GetRepositoryMock(new List<IPrescriptionProduct>());
            var productRepository = GetRepositoryMock(products);
            var dataService = new DataService(productComparer, commercialProductRepository, nameRepository, prescriptionProductRepository, productRepository);

            int result = dataService.GetProductCount();

            Assert.AreEqual(products.Count, result);
        }
    }
}
