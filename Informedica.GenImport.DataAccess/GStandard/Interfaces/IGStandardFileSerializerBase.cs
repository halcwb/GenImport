using Informedica.GenImport.Library.DomainModel.Interfaces;

namespace Informedica.GenImport.DataAccess.GStandard.Interfaces
{
    public interface IGStandardFileSerializerBase<TModel> : IFileSerializerBase<TModel>
        where TModel : class, IGStandardModel, new()
    {
    }
}
