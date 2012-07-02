using Informedica.GenImport.Library.DomainModel.Interfaces;
using Informedica.GenImport.Services;

namespace Informedica.GenImport.GStandard.Services
{
    public interface IGStandardImportService<TModel> : IImportService
        where TModel : class, IModel
    {
    }
}
