using System.Reflection;
using System.ServiceProcess;
using Bootstrap;
using Bootstrap.AutoMapper;
using Bootstrap.StructureMap;
using Informedica.GenImport.DataAccess.StructureMap;
using Informedica.GenImport.Library.AutoMapper;

namespace Informedica.GenImport
{
    static class Program
    {
        static void Main()
        {
            Bootstrapper.IncludingOnly
                .Assembly(Assembly.GetAssembly(typeof(ModelMappingProfile)))
                .AndAssembly(Assembly.GetAssembly(typeof(GStandardFileSerializerRegistry)))
                .With.AutoMapper().And.StructureMap()
                .Start();

            ServiceBase[] servicesToRun = new ServiceBase[] 
                                              { 
                                                  new GenImportService()
                                              };
            ServiceBase.Run(servicesToRun);
        }
    }
}
