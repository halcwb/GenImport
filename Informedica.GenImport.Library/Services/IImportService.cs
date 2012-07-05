using Informedica.GenImport.Library.DomainModel.Interfaces;

namespace Informedica.GenImport.Library.Services
{
    public interface IImportService
    {
        void Start();
        void Stop();
    }

    public interface IImportService<TModel> : IImportService
        where TModel : class, IModel
    {
    }
}
