using System;
using System.Reflection;
using System.ServiceProcess;
using Bootstrap;
using Bootstrap.AutoMapper;
using Bootstrap.StructureMap;
using Informedica.GenImport.DataAccess;
using Informedica.GenImport.DataAccess.StructureMap;
using Informedica.GenImport.Library.AutoMapper;
using Informedica.GenImport.Library.DomainModel.Interfaces;
using StructureMap;

namespace Informedica.GenImport
{
    static class Program
    {
        static void Main()
        {
            ServiceBase[] servicesToRun = new ServiceBase[] 
                                              { 
                                                  new GenImportService()
                                              };
            ServiceBase.Run(servicesToRun);
        }
    }
}
