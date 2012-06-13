using System.ServiceProcess;

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
