using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using StructureMap.Configuration.DSL;

namespace Informedica.GenImport.GStandard.StructureMap
{
    public class EqualityRegistry : Registry
    {
        public EqualityRegistry()
        {
            For<IEqualityComparer<ICommercialProduct>>().Use<CommercialProductComparer>();
            For<IEqualityComparer<IComposition>>().Use<CompositionComparer>();
            For<IEqualityComparer<IGenericComposition>>().Use<GenericCompositionComparer>();
            For<IEqualityComparer<IGenericName>>().Use<GenericNameComparer>();
            For<IEqualityComparer<IGenericProduct>>().Use<GenericProductComparer>();
            For<IEqualityComparer<IName>>().Use<NameComparer>();
            For<IEqualityComparer<IPrescriptionProduct>>().Use<PrescriptionProductComparer>();
            For<IEqualityComparer<IProduct>>().Use<ProductComparer>();
            For<IEqualityComparer<IRelationBetweenName>>().Use<RelationBetweenNameComparer>();
            For<IEqualityComparer<IThesauriTotal>>().Use<ThesauriTotalComparer>();
        }
    }
}
