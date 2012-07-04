using AutoMapper;
using Informedica.GenImport.GStandard.AutoMapper;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.Library.DomainModel.Product;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Product = Informedica.GenImport.GStandard.DomainModel.Product;

namespace Informedica.GenImport.GStandard.Tests
{
    [TestClass]
    public class ModelMappingProfileShould
    {
        public ModelMappingProfileShould()
        {
            Mapper.AddProfile(new ModelMappingProfile());
            Mapper.AssertConfigurationIsValid();
        }

        [TestMethod]
        public void Map_Artikel_To_Product()
        {
            Product gStandardProduct = new Product { HpKode = 1234 };
            Library.DomainModel.Product.Product product = Mapper.Map<Product, Library.DomainModel.Product.Product>(gStandardProduct);

            //TODO implement tests
            //Assert.AreEqual(artikel.HpKode, product.ProductCode);
        }
    }
}
