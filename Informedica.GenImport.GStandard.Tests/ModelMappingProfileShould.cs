﻿using AutoMapper;
using Informedica.GenImport.GStandard.AutoMapper;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.Library.DomainModel.Product;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            Artikel artikel = new Artikel { HpKode = 1234 };
            Product product = Mapper.Map<Artikel, Product>(artikel);

            //TODO implement tests
            //Assert.AreEqual(artikel.HpKode, product.ProductCode);
        }
    }
}