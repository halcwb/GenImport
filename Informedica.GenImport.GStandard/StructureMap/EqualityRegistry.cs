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
            For<IEqualityComparer<IName>>().Use<NameComparer>();
        }
    }
}
