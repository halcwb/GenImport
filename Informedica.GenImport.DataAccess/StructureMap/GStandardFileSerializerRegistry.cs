using StructureMap.Configuration.DSL;
using Informedica.GenImport.DataAccess.GStandard.Interfaces;
using Informedica.GenImport.DataAccess.GStandard;

namespace Informedica.GenImport.DataAccess.StructureMap
{
    public class GStandardFileSerializerRegistry : Registry
    {
        public GStandardFileSerializerRegistry()
        {
            For<IGStandardArtikelenFileSerializer>().Use<GStandardArtikelenFileSerializer>();
            For<IGStandardNamenFileSerializer>().Use<GStandardNamenFileSerializer>();
        }
    }
}
