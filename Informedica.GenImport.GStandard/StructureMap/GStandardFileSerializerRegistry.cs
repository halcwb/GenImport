using Informedica.GenImport.DataAccess;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Files;
using StructureMap.Configuration.DSL;

namespace Informedica.GenImport.GStandard.StructureMap
{
    public class GStandardFileSerializerRegistry : Registry
    {
        public GStandardFileSerializerRegistry()
        {
            For<IFileSerializerBase<IProduct>>().Use<ProductFileSerializer>();
            For<IFileSerializerBase<IName>>().Use<NameFileSerializer>();
            For<IFileSerializerBase<IThesauriTotal>>().Use<ThesauriTotalFileSerializer>();
        }
    }
}
