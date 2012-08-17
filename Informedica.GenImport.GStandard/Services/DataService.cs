using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using Informedica.EntityRepository.Entities;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Repositories;
using Informedica.GenImport.Library.DomainModel.Product;
using Informedica.GenImport.Library.Exceptions;
using Informedica.GenImport.Library.Services;

namespace Informedica.GenImport.GStandard.Services
{
    public class DataService : IDataService
    {
        private readonly IEqualityComparer<IProduct> _productComparer;
        private readonly IRepository<ICommercialProduct> _commercialProductRepository;
        private readonly IRepository<IName> _nameRepository;
        private readonly IRepository<IPrescriptionProduct> _prescriptionProductRepository;
        private readonly IRepository<IProduct> _productRepository;

        public DataService(IEqualityComparer<IProduct> productComparer, IRepository<ICommercialProduct> commercialProductRepository, IRepository<IName> nameRepository,
            IRepository<IPrescriptionProduct> prescriptionProductRepository, IRepository<IProduct> productRepository)
        {
            Contract.Requires<ArgumentNullException>(productComparer != null, "productComparer");
            Contract.Requires<ArgumentNullException>(commercialProductRepository != null, "commercialProductRepository");
            Contract.Requires<ArgumentNullException>(nameRepository != null, "nameRepository");
            Contract.Requires<ArgumentNullException>(prescriptionProductRepository != null, "prescriptionProductRepository");
            Contract.Requires<ArgumentNullException>(productRepository != null, "productRepository");

            _productComparer = productComparer;
            _commercialProductRepository = commercialProductRepository;
            _nameRepository = nameRepository;
            _prescriptionProductRepository = prescriptionProductRepository;
            _productRepository = productRepository;
        }

        #region Implementation of IDataService

        public int GetProductCount()
        {
            return _productRepository.GetQueryable().Count(p => p.MutKod != MutKod.RecordDeleted);
        }

        public IEnumerable<Product> GetProductsByProductCode(int productCode)
        {
            var products =
                _productRepository.GetQueryable().Where(p => p.HpKode == productCode && p.MutKod != MutKod.RecordDeleted).Select(
                    CreateProduct).ToList();

            return products;
        }

        public IEnumerable<Product> FindProductsByName(string name)
        {
            var nameIds =
                _nameRepository.GetQueryable().Where(
                    n =>
                    n.MutKod != MutKod.RecordDeleted && n.NmNaam.ToLowerInvariant().Contains(name)).Select(n => n.Id);

            var commercialProductIds =
                _commercialProductRepository.GetQueryable().Where(
                    cp =>
                    cp.MutKod != MutKod.RecordDeleted &&
                    (nameIds.Contains(cp.HpNamN) || cp.MsNaam.ToLowerInvariant().Contains(name))).Select(cp => cp.Id);

            var products =
                _productRepository.GetQueryable().Where(
                    p => nameIds.Contains(p.AtNmNr) || commercialProductIds.Contains(p.HpKode)).
                    ToList().Distinct(_productComparer).Select(CreateProduct).ToList();

            return products;
        }

        #endregion

        private Product CreateProduct(IProduct product)
        {
            IName productName = GetEntity(_nameRepository, product.AtNmNr);
            ICommercialProduct commercialProduct = GetEntity(_commercialProductRepository, product.HpKode);

            return new Product
            {
                Name = productName.NmNaam,
                ProductCode = product.HpKode,
                Brand = new Brand { Name = commercialProduct.MsNaam },
            };
        }

        private static TEnt GetEntity<TEnt>(IRepository<TEnt> repository, int id)
            where TEnt : class, IEntity<TEnt, int>
        {
            TEnt entity = repository.GetById(id);
            if (entity == null)
            {
                throw new ProductIncompleteException(string.Format(CultureInfo.InvariantCulture,
                                                                   "Could not retrieve {0} from the database with id '{1}'.", typeof(TEnt), id));
            }
            return entity;
        }
    }
}
