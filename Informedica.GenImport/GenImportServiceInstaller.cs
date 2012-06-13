using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;


namespace Informedica.GenImport
{
    [RunInstaller(true)]
    public partial class GenImportServiceInstaller : System.Configuration.Install.Installer
    {
        public GenImportServiceInstaller()
        {
            InitializeComponent();
        }
    }
}
