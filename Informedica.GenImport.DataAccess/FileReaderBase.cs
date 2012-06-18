using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Informedica.GenForm.DomainModel.Interfaces;
using Informedica.GenImport.Library.DomainModel;
using Informedica.GenImport.Library.DomainModel.Interfaces;

namespace Informedica.GenImport.DataAccess
{
    public abstract class FileReaderBase<TModel> 
        where TModel : IModel
    {
        
        public IEnumerable<TModel> ReadLines(Stream inputStream)
        {
            
            throw new NotImplementedException();
        }
        
        protected abstract TModel ParseLineToModel(string line);
    }
}
