using System.IO;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Repositories;
using Informedica.GenImport.Library.Serialization;

namespace Informedica.GenImport.GStandard.Services
{
    //TODO might want to introduce UnitOfWork
    //TODO combine with its base class when it seems ready
    public class ImportService<TModel> : GStandardImportServiceBase<TModel>
        where TModel : class, IGStandardModel<TModel>
    {
        public ImportService(string databaseFilePath, IFileSerializer<TModel> fileSerializer, IRepository<TModel> repository)
            : base(databaseFilePath, fileSerializer, repository)
        {
        }

        protected override void Import(Stream stream)
        {
            ProcessFile(stream, n => Repository.Add(n));
        }
    }
}
