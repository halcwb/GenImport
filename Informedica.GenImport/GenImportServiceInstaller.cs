using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;


namespace Informedica.GenImport
{
    [RunInstaller(true)]
    public partial class GenImportServiceInstaller : Installer
    {
        public GenImportServiceInstaller()
        {
            InitializeComponent();
        }

        public override void Install(IDictionary stateSaver)
        {
            ServiceInstaller myServiceInstaller = new ServiceInstaller
            {
                ServiceName = "Informedica GenImportService",
                DisplayName = "Informedica GenImportService",
                StartType = ServiceStartMode.Automatic,
                Description = "Provides import functionality for Informedica GenForm."
            };

            Installers.Add(myServiceInstaller);

            ServiceProcessInstaller myProcessInstaller = new ServiceProcessInstaller { Account = ServiceAccount.NetworkService };
            Installers.Add(myProcessInstaller);

            base.Install(stateSaver);
        }
    }
}
