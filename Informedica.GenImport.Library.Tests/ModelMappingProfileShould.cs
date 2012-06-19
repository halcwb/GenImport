using AutoMapper;
using Informedica.GenImport.Library.AutoMapper;
using Informedica.GenImport.Library.DomainModel.GStandard;
using Informedica.GenImport.Library.DomainModel.Product;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.Library.Tests
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
            Artikel artikel = new Artikel { HpKode = 1234 };
            Product product = Mapper.Map<Artikel, Product>(artikel);

            Assert.AreEqual(artikel.HpKode, product.ProductCode);
        }
    }
}
