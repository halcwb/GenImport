using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.Library.Serialization;
using StructureMap.Configuration.DSL;

namespace Informedica.GenImport.GStandard.StructureMap
{
    public class GStandardFileSerializerRegistry : Registry
    {
        public GStandardFileSerializerRegistry()
        {
            //For<IFileSerializer<IProduct>>().Use<ProductFileSerializer>();
            //For<IFileSerializer<IName>>().Use<NameFileSerializer>();
            //For<IFileSerializer<IThesauriTotal>>().Use<ThesauriTotalFileSerializer>();
        }
    }
}
