using System.Threading;
using Informedica.GenImport.Library.DomainModel.Interfaces;

namespace Informedica.GenImport.Library.Services
{
    public interface IImportService
    {
        void Start(CancellationToken cancellationToken);
        bool IsRunning { get; }
    }

    public interface IImportService<TModel> : IImportService
        where TModel : class, IModel
    {
    }
}
