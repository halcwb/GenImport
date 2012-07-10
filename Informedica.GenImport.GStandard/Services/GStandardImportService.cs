﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.Library.Services;

namespace Informedica.GenImport.GStandard.Services
{
    public class GStandardImportService : IImportService
    {
        private readonly IList<IImportService> _importServices;
        private CancellationToken _cancellationToken = new CancellationToken();

        public GStandardImportService(IImportService<ICommercialProduct> commercialProductImportService, IImportService<IComposition> compositionImportService,
            IImportService<IGenericComposition> genericCompositionImportService, IImportService<IGenericName> genericNameImportService, IImportService<IGenericProduct> genericProductImportService,
            IImportService<IName> nameImportService, IImportService<IPrescriptionProduct> prescriptionProductImportService, IImportService<IThesauriTotal> thesauriTotalImportService)
        {
            if (commercialProductImportService == null) throw new ArgumentNullException("commercialProductImportService");
            if (compositionImportService == null) throw new ArgumentNullException("compositionImportService");
            if (genericCompositionImportService == null) throw new ArgumentNullException("genericCompositionImportService");
            if (genericNameImportService == null) throw new ArgumentNullException("genericNameImportService");
            if (genericProductImportService == null) throw new ArgumentNullException("genericProductImportService");
            if (nameImportService == null) throw new ArgumentNullException("nameImportService");
            if (prescriptionProductImportService == null) throw new ArgumentNullException("prescriptionProductImportService");
            if (thesauriTotalImportService == null) throw new ArgumentNullException("thesauriTotalImportService");

            //TODO be sure to set order according to references used by entities
            _importServices = new List<IImportService>{
                                                          commercialProductImportService,
                                                          compositionImportService,
                                                          genericCompositionImportService,
                                                          genericNameImportService,
                                                          genericProductImportService,
                                                          nameImportService,
                                                          prescriptionProductImportService,
                                                          thesauriTotalImportService
                                                      };
        }

        #region Implementation of IImportService

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
