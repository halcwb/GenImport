using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.DataAccess;
using Informedica.GenImport.GStandard.IO;
using StructureMap.Configuration.DSL;

namespace Informedica.GenImport.GStandard.StructureMap
{
    public class GStandardFileSerializerRegistry : Registry
    {
        public GStandardFileSerializerRegistry()
        {
            For<IFileSerializerBase<IArtikel>>().Use<ArtikelenFileSerializer>();
            For<IFileSerializerBase<INaam>>().Use<NamenFileSerializer>();
            For<IFileSerializerBase<IThesauriTotaal>>().Use<ThesauriTotaalFileSerializer>();
        }
    }
}
