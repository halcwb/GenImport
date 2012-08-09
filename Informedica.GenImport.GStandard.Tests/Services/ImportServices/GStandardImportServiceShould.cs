using System;
using System.Threading;
using System.Threading.Tasks;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Services;
using Informedica.GenImport.Library.DomainModel.Interfaces;
using Informedica.GenImport.Library.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Informedica.GenImport.GStandard.Tests.Services.ImportServices
{
    [TestClass]
    public class GStandardImportServiceShould
    {
        #region Helpers

        private static IImportService<TModel> GetMockImportService<TModel>()
            where TModel : class, IModel
        {
            return GetMockImportService<TModel>(() => { });
        }

        private static IImportService<TModel> GetMockImportService<TModel>(Action startAction)
            where TModel : class, IModel
        {
            return GetMockImportService<TModel>(startAction, false);
        }

        private static IImportService<TModel> GetMockImportService<TModel>(Action startAction, bool isRunning)
            where TModel : class, IModel
        {
            var mockImportService = new Mock<IImportService<TModel>>(MockBehavior.Strict);
            mockImportService.Setup(s => s.Start(It.IsAny<CancellationToken>())).Callback(startAction);
            mockImportService.Setup(s => s.IsRunning).Returns(isRunning);
            return mockImportService.Object;
        }

        private static CancellationToken GetToken()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            return cancellationTokenSource.Token;
        }

        private class ThreadedImportService<TModel> : IImportService<TModel>
            where TModel : class, IModel
        {
            #region Implementation of IImportService

            public void Start(CancellationToken cancellationToken)
            {

            }

            public bool IsRunning
            {
                get { throw new NotImplementedException(); }
            }
            #endregion
        }

        private static ThreadedImportService<TModel> GetThreadedImportService<TModel>()
            where TModel : class, IModel
        {
            return new ThreadedImportService<TModel>();
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
            var service = new GStandardImportService(
                GetMockImportService<ICommercialProduct>(() => serviceStarted = true),
                GetMockImportService<IComposition>(),
                GetMockImportService<IGenericComposition>(), GetMockImportService<IGenericName>(),
                GetMockImportService<IGenericProduct>(), GetMockImportService<IName>(),
                GetMockImportService<IPrescriptionProduct>(),
                GetMockImportService<IThesauriTotal>());

            service.Start(GetToken());

            Assert.IsTrue(serviceStarted);
        }

        [TestMethod]
        public void Start_CompositionImportService_When_Start_Is_Called()
        {
            bool serviceStarted = false;
            var service = new GStandardImportService(GetMockImportService<ICommercialProduct>(),
                                       GetMockImportService<IComposition>(() => serviceStarted = true),
                                       GetMockImportService<IGenericComposition>(), GetMockImportService<IGenericName>(),
                                       GetMockImportService<IGenericProduct>(), GetMockImportService<IName>(),
                                       GetMockImportService<IPrescriptionProduct>(),
                                       GetMockImportService<IThesauriTotal>());

            service.Start(GetToken());

            Assert.IsTrue(serviceStarted);
        }

        [TestMethod]
        public void Start_GenericCompositionImportService_When_Start_Is_Called()
        {
            bool serviceStarted = false;
            var service = new GStandardImportService(GetMockImportService<ICommercialProduct>(), GetMockImportService<IComposition>(),
                                       GetMockImportService<IGenericComposition>(() => serviceStarted = true),
                                       GetMockImportService<IGenericName>(),
                                       GetMockImportService<IGenericProduct>(), GetMockImportService<IName>(),
                                       GetMockImportService<IPrescriptionProduct>(),
                                       GetMockImportService<IThesauriTotal>());

            service.Start(GetToken());

            Assert.IsTrue(serviceStarted);
        }

        [TestMethod]
        public void Start_GenericNameImportService_When_Start_Is_Called()
        {
            bool serviceStarted = false;
            var service = new GStandardImportService(GetMockImportService<ICommercialProduct>(), GetMockImportService<IComposition>(),
                                       GetMockImportService<IGenericComposition>(),
                                       GetMockImportService<IGenericName>(() => serviceStarted = true),
                                       GetMockImportService<IGenericProduct>(), GetMockImportService<IName>(),
                                       GetMockImportService<IPrescriptionProduct>(),
                                       GetMockImportService<IThesauriTotal>());

            service.Start(GetToken());

            Assert.IsTrue(serviceStarted);
        }

        [TestMethod]
        public void Start_GenericProductImportService_When_Start_Is_Called()
        {
            bool serviceStarted = false;
            var service = new GStandardImportService(GetMockImportService<ICommercialProduct>(), GetMockImportService<IComposition>(),
                                       GetMockImportService<IGenericComposition>(), GetMockImportService<IGenericName>(),
                                       GetMockImportService<IGenericProduct>(() => serviceStarted = true),
                                       GetMockImportService<IName>(),
                                       GetMockImportService<IPrescriptionProduct>(),
                                       GetMockImportService<IThesauriTotal>());

            service.Start(GetToken());

            Assert.IsTrue(serviceStarted);
        }

        [TestMethod]
        public void Start_NameImportService_When_Start_Is_Called()
        {
            bool serviceStarted = false;
            var service = new GStandardImportService(GetMockImportService<ICommercialProduct>(), GetMockImportService<IComposition>(),
                                       GetMockImportService<IGenericComposition>(), GetMockImportService<IGenericName>(),
                                       GetMockImportService<IGenericProduct>(),
                                       GetMockImportService<IName>(() => serviceStarted = true),
                                       GetMockImportService<IPrescriptionProduct>(),
                                       GetMockImportService<IThesauriTotal>());

            service.Start(GetToken());

            Assert.IsTrue(serviceStarted);
        }

        [TestMethod]
        public void Start_PrescriptionProductImportService_When_Start_Is_Called()
        {
            bool serviceStarted = false;
            var service = new GStandardImportService(GetMockImportService<ICommercialProduct>(), GetMockImportService<IComposition>(),
                                       GetMockImportService<IGenericComposition>(), GetMockImportService<IGenericName>(),
                                       GetMockImportService<IGenericProduct>(), GetMockImportService<IName>(),
                                       GetMockImportService<IPrescriptionProduct>(() => serviceStarted = true),
                                       GetMockImportService<IThesauriTotal>());

            service.Start(GetToken());

            Assert.IsTrue(serviceStarted);
        }

        [TestMethod]
        public void Start_ThesauriTotalImportService_When_Start_Is_Called()
        {
            bool serviceStarted = false;
            var service = new GStandardImportService(GetMockImportService<ICommercialProduct>(), GetMockImportService<IComposition>(),
                                       GetMockImportService<IGenericComposition>(), GetMockImportService<IGenericName>(),
                                       GetMockImportService<IGenericProduct>(), GetMockImportService<IName>(),
                                       GetMockImportService<IPrescriptionProduct>(),
                                       GetMockImportService<IThesauriTotal>(() => serviceStarted = true));

            service.Start(GetToken());

            Assert.IsTrue(serviceStarted);
        }
        #endregion

        #region Threading

        [TestMethod]
        public void Be_Able_To_Return_Running_True_When_An_ImportService_Is_Still_Running()
        {
            var service = new GStandardImportService(
                GetMockImportService<ICommercialProduct>(() => Thread.Sleep(1000), true),
                GetMockImportService<IComposition>(),
                GetMockImportService<IGenericComposition>(),
                GetMockImportService<IGenericName>(),
                GetMockImportService<IGenericProduct>(),
                GetMockImportService<IName>(),
                GetMockImportService<IPrescriptionProduct>(),
                GetMockImportService<IThesauriTotal>());

            var token = GetToken();
            Task.Factory.StartNew(() => service.Start(token), token);
         
            Assert.IsTrue(service.IsRunning);
        }

        [TestMethod]
        public void Be_Able_To_Run_Threaded_And_Be_Canceled_Via_The_CancellationToken()
        {
            bool cancelled = false;
            var service = new GStandardImportService(
                GetMockImportService<ICommercialProduct>(() => Thread.Sleep(100), true),
                GetMockImportService<IComposition>(() => Thread.Sleep(100), true),
                GetMockImportService<IGenericComposition>(() => Thread.Sleep(100), true),
                GetMockImportService<IGenericName>(() => Thread.Sleep(100), true),
                GetMockImportService<IGenericProduct>(() => Thread.Sleep(100), true),
                GetMockImportService<IName>(() => Thread.Sleep(100), true),
                GetMockImportService<IPrescriptionProduct>(() => Thread.Sleep(100), true),
                GetMockImportService<IThesauriTotal>(() => Thread.Sleep(100), true));

            var tokenSoure = new CancellationTokenSource();
            var token = tokenSoure.Token;
            Task.Factory.StartNew(() => service.Start(token), token);

            token.Register(() => cancelled = true);
            tokenSoure.Cancel();

            Assert.IsTrue(cancelled);
        }
        


        #endregion
    }
}
