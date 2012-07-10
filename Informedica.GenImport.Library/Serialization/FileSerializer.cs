﻿using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Informedica.GenImport.Library.DomainModel.Interfaces;
using Informedica.GenImport.Library.Exceptions;

namespace Informedica.GenImport.Library.Serialization
{
    public abstract class FileSerializer<TModel> : IFileSerializer<TModel>
        where TModel : class, IModel
    {
        public virtual IEnumerable<TModel> ReadLines(Stream inputStream)
        {
            using (StreamReader streamReader = new StreamReader(inputStream))
            {
                string line;
                int lineNumber = 1;
                while ((line = streamReader.ReadLine()) != null)
                {
#if DEBUG
                    if(lineNumber == 34454) Debugger.Break();
#endif
                    TModel model = TryParseLine(line);
                    if(model != null)
                    {
                        yield return model;
                    }
                    lineNumber++;
                }
            }
        }

        private TModel TryParseLine(string line)
        {
            TModel model = null;
            try
            {
                model = ParseLineToModel(line);
            }
            catch (CannotParseLineException ex)
            {
                //TODO log
                Debug.WriteLine(string.Format("Cannot parse line to model. Reason: {0}", ex.StackTrace));
            }
            return model;
        }

        protected abstract TModel ParseLineToModel(string line);
        
        IEnumerable<IModel> IFileSerializer.ReadLines(Stream inputStream)
        {
            return ReadLines(inputStream);
        }
    }
}
