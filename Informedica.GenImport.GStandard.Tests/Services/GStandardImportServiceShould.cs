using System;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Services;
using Informedica.GenImport.Library.DomainModel.Interfaces;
using Informedica.GenImport.Library.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Informedica.GenImport.GStandard.Tests.Services
{
    [TestClass]
    public class GStandardImportServiceShould
    {
        #region Helpers

        private static IImportService<TModel> GetMockImportService<TModel>()
            where TModel : class, IModel
        {
            return GetMockImportService<TModel>(() => { }, () => { });
        }

        private static IImportService<TModel> GetMockImportService<TModel>(Action startAction, Action stopAction)
            where TModel : class, IModel
        {
            var mockImportService = new Mock<IImportService<TModel>>(MockBehavior.Strict);
            mockImportService.Setup(s => s.Start()).Callback(startAction);
            mockImportService.Setup(s => s.Stop()).Callback(stopAction);
            return mockImportService.Object;
        }

        #endregion

        #region ArgumentNullException

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Test")]
        public void Throw_ArgumentNullException_When_Constructor_Is_Called_With_CommercialProductImportService_Null()
        {
            new GStandardImportService(null, GetMockImportService<IComposition>(),
                                       GetMockImportService<IGenericComposition>(), GetMockImportService<IGenericName>(),
                                       GetMockImportService<IGenericProduct>(), GetMockImportService<IName>(),
                                       GetMockImportService<IPrescriptionProduct>(),
                                       GetMockImportService<IThesauriTotal>());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Throw_ArgumentNullException_When_Constructor_Is_Called_With_CompositionImportService_Null()
        {
            new GStandardImportService(GetMockImportService<ICommercialProduct>(), null,
                                       GetMockImportService<IGenericComposition>(), GetMockImportService<IGenericName>(),
                                       GetMockImportService<IGenericProduct>(), GetMockImportService<IName>(),
                                       GetMockImportService<IPrescriptionProduct>(),
                                       GetMockImportService<IThesauriTotal>());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Throw_ArgumentNullException_When_Constructor_Is_Called_With_GenericCompositionImportService_Null()
        {
            new GStandardImportService(GetMockImportService<ICommercialProduct>(), GetMockImportService<IComposition>(),
                                        null, GetMockImportService<IGenericName>(),
                                        GetMockImportService<IGenericProduct>(), GetMockImportService<IName>(),
                                        GetMockImportService<IPrescriptionProduct>(),
                                        GetMockImportService<IThesauriTotal>());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Throw_ArgumentNullException_When_Constructor_Is_Called_With_GenericNameImportService_Null()
        {
            new GStandardImportService(GetMockImportService<ICommercialProduct>(), GetMockImportService<IComposition>(),
                                       GetMockImportService<IGenericComposition>(), null,
                                       GetMockImportService<IGenericProduct>(), GetMockImportService<IName>(),
                                       GetMockImportService<IPrescriptionProduct>(),
                                       GetMockImportService<IThesauriTotal>());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Throw_ArgumentNullException_When_Constructor_Is_Called_With_GenericProductImportService_Null()
        {
            new GStandardImportService(GetMockImportService<ICommercialProduct>(), GetMockImportService<IComposition>(),
                                       GetMockImportService<IGenericComposition>(), GetMockImportService<IGenericName>(),
                                       null, GetMockImportService<IName>(),
                                       GetMockImportService<IPrescriptionProduct>(),
                                       GetMockImportService<IThesauriTotal>());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Throw_ArgumentNullException_When_Constructor_Is_Called_With_NameImportService_Null()
        {
            new GStandardImportService(GetMockImportService<ICommercialProduct>(), GetMockImportService<IComposition>(),
                                       GetMockImportService<IGenericComposition>(), GetMockImportService<IGenericName>(),
                                       GetMockImportService<IGenericProduct>(), null,
                                       GetMockImportService<IPrescriptionProduct>(),
                                       GetMockImportService<IThesauriTotal>());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Throw_ArgumentNullException_When_Constructor_Is_Called_With_PrescriptionProductImportService_Null()
        {
            new GStandardImportService(GetMockImportService<ICommercialProduct>(), GetMockImportService<IComposition>(),
                                       GetMockImportService<IGenericComposition>(), GetMockImportService<IGenericName>(),
                                       GetMockImportService<IGenericProduct>(), GetMockImportService<IName>(),
                                       null,
                                       GetMockImportService<IThesauriTotal>());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Throw_ArgumentNullException_When_Constructor_Is_Called_With_ThesauriTotalImportService_Null()
        {
            new GStandardImportService(GetMockImportService<ICommercialProduct>(), GetMockImportService<IComposition>(),
                                       GetMockImportService<IGenericComposition>(), GetMockImportService<IGenericName>(),
                                       GetMockImportService<IGenericProduct>(), GetMockImportService<IName>(),
                                       GetMockImportService<IPrescriptionProduct>(),
                                       null);
        }

        #endregion

        #region Start

        [TestMethod]
        public void Start_CommercialProductImportService_When_Start_Is_Called()
        {
            bool serviceStarted = false;
            new GStandardImportService(
                GetMockImportService<ICommercialProduct>(() => serviceStarted = true, () => { }),
                GetMockImportService<IComposition>(),
                GetMockImportService<IGenericComposition>(), GetMockImportService<IGenericName>(),
                GetMockImportService<IGenericProduct>(), GetMockImportService<IName>(),
                GetMockImportService<IPrescriptionProduct>(),
                GetMockImportService<IThesauriTotal>());
            Assert.IsTrue(serviceStarted);
        }

        [TestMethod]
        public void Start_CompositionImportService_When_Start_Is_Called()
        {
            bool serviceStarted = false;
            new GStandardImportService(GetMockImportService<ICommercialProduct>(),
                                       GetMockImportService<IComposition>(() => serviceStarted = true, () => { }),
                                       GetMockImportService<IGenericComposition>(), GetMockImportService<IGenericName>(),
                                       GetMockImportService<IGenericProduct>(), GetMockImportService<IName>(),
                                       GetMockImportService<IPrescriptionProduct>(),
                                       GetMockImportService<IThesauriTotal>());
            Assert.IsTrue(serviceStarted);
        }

        [TestMethod]
        public void Start_GenericCompositionImportService_When_Start_Is_Called()
        {
            bool serviceStarted = false;
            new GStandardImportService(GetMockImportService<ICommercialProduct>(), GetMockImportService<IComposition>(),
                                       GetMockImportService<IGenericComposition>(() => serviceStarted = true, () => { }),
                                       GetMockImportService<IGenericName>(),
                                       GetMockImportService<IGenericProduct>(), GetMockImportService<IName>(),
                                       GetMockImportService<IPrescriptionProduct>(),
                                       GetMockImportService<IThesauriTotal>());
            Assert.IsTrue(serviceStarted);
        }

        [TestMethod]
        public void Start_GenericNameImportService_When_Start_Is_Called()
        {
            bool serviceStarted = false;
            new GStandardImportService(GetMockImportService<ICommercialProduct>(), GetMockImportService<IComposition>(),
                                       GetMockImportService<IGenericComposition>(),
                                       GetMockImportService<IGenericName>(() => serviceStarted = true, () => { }),
                                       GetMockImportService<IGenericProduct>(), GetMockImportService<IName>(),
                                       GetMockImportService<IPrescriptionProduct>(),
                                       GetMockImportService<IThesauriTotal>());
            Assert.IsTrue(serviceStarted);
        }

        [TestMethod]
        public void Start_GenericProductImportService_When_Start_Is_Called()
        {
            bool serviceStarted = false;
            new GStandardImportService(GetMockImportService<ICommercialProduct>(), GetMockImportService<IComposition>(),
                                       GetMockImportService<IGenericComposition>(), GetMockImportService<IGenericName>(),
                                       GetMockImportService<IGenericProduct>(() => serviceStarted = true, () => { }),
                                       GetMockImportService<IName>(),
                                       GetMockImportService<IPrescriptionProduct>(),
                                       GetMockImportService<IThesauriTotal>());
            Assert.IsTrue(serviceStarted);
        }

        [TestMethod]
        public void Start_NameImportService_When_Start_Is_Called()
        {
            bool serviceStarted = false;
            new GStandardImportService(GetMockImportService<ICommercialProduct>(), GetMockImportService<IComposition>(),
                                       GetMockImportService<IGenericComposition>(), GetMockImportService<IGenericName>(),
                                       GetMockImportService<IGenericProduct>(),
                                       GetMockImportService<IName>(() => serviceStarted = true, () => { }),
                                       GetMockImportService<IPrescriptionProduct>(),
                                       GetMockImportService<IThesauriTotal>());
            Assert.IsTrue(serviceStarted);
        }

        [TestMethod]
        public void Start_PrescriptionProductImportService_When_Start_Is_Called()
        {
            bool serviceStarted = false;
            new GStandardImportService(GetMockImportService<ICommercialProduct>(), GetMockImportService<IComposition>(),
                                       GetMockImportService<IGenericComposition>(), GetMockImportService<IGenericName>(),
                                       GetMockImportService<IGenericProduct>(), GetMockImportService<IName>(),
                                       GetMockImportService<IPrescriptionProduct>(() => serviceStarted = true, () => { }),
                                       GetMockImportService<IThesauriTotal>());
            Assert.IsTrue(serviceStarted);
        }

        [TestMethod]
        public void Start_ThesauriTotalImportService_When_Start_Is_Called()
        {
            bool serviceStarted = false;
            new GStandardImportService(GetMockImportService<ICommercialProduct>(), GetMockImportService<IComposition>(),
                                       GetMockImportService<IGenericComposition>(), GetMockImportService<IGenericName>(),
                                       GetMockImportService<IGenericProduct>(), GetMockImportService<IName>(),
                                       GetMockImportService<IPrescriptionProduct>(),
                                       GetMockImportService<IThesauriTotal>(() => serviceStarted = true, () => { }));
            Assert.IsTrue(serviceStarted);
        }
        #endregion

        #region Stop
        //TODO implement
        #endregion
    }
}
