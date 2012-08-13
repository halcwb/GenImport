using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Diagnostics.Contracts;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.Library.Services;

namespace Informedica.GenImport.GStandard.Services
{
    public class GStandardImportService : IImportService
    {
        private readonly IList<IImportService> _importServices;
        private readonly CancellationToken _cancellationToken = new CancellationToken();

        [Pure]
        public GStandardImportService(IImportService<ICommercialProduct> commercialProductImportService, IImportService<IComposition> compositionImportService,
            IImportService<IGenericComposition> genericCompositionImportService, IImportService<IGenericName> genericNameImportService, IImportService<IGenericProduct> genericProductImportService,
            IImportService<IName> nameImportService, IImportService<IPrescriptionProduct> prescriptionProductImportService, IImportService<IProduct> productImportService, IImportService<IThesauriTotal> thesauriTotalImportService)
        {
            Contract.Requires<ArgumentNullException>(commercialProductImportService != null, "commercialProductImportService");
            Contract.Requires<ArgumentNullException>(compositionImportService != null, "compositionImportService");
            Contract.Requires<ArgumentNullException>(genericCompositionImportService != null, "genericCompositionImportService");
            Contract.Requires<ArgumentNullException>(genericNameImportService != null, "genericNameImportService");
            Contract.Requires<ArgumentNullException>(genericProductImportService != null, "genericProductImportService");
            Contract.Requires<ArgumentNullException>(nameImportService != null, "nameImportService");
            Contract.Requires<ArgumentNullException>(prescriptionProductImportService != null, "prescriptionProductImportService");
            Contract.Requires<ArgumentNullException>(productImportService != null, "productImportService");
            //TODO relationBetweenName
            Contract.Requires<ArgumentNullException>(thesauriTotalImportService != null, "thesauriTotalImportService");

            _importServices = new List<IImportService>{
                                                          commercialProductImportService,
                                                          compositionImportService,
                                                          genericCompositionImportService,
                                                          genericNameImportService,
                                                          genericProductImportService,
                                                          nameImportService,
                                                          prescriptionProductImportService,
                                                          productImportService,
                                                          thesauriTotalImportService
                                                      };
        }

        #region Implementation of IImportService
        
        [Pure]
        public void Start(CancellationToken cancellationToken)
        {
            if (IsRunning) return;

            foreach (var importService in _importServices)
            {
                importService.Start(_cancellationToken);
                if (cancellationToken.IsCancellationRequested)
                {
                    break;
                }
            }
        }

        [Pure]
        public bool IsRunning
        {
            get
            {
                return _importServices.Any(s => s.IsRunning);
            }
        }

        #endregion
    }
}
