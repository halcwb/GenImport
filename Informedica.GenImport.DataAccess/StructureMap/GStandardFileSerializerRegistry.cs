using Informedica.GenImport.Library.DomainModel.Interfaces;
using StructureMap.Configuration.DSL;
using Informedica.GenImport.DataAccess.GStandard;

namespace Informedica.GenImport.DataAccess.StructureMap
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
