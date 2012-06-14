using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace Informedica.GenImport
{
    partial class GenImportService : ServiceBase
    {
        public GenImportService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //TODO add logic
        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override void OnStop()
        {
            //TODO add logic
        }
    }
}
