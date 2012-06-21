using System.Collections.Generic;
using System.IO;
using Informedica.GenImport.Library.DomainModel.Interfaces;

namespace Informedica.GenImport.DataAccess
{
    public interface IFileSerializerBase<out TModel>
        where TModel : class, IModel
    {
        IEnumerable<TModel> ReadLines(Stream inputStream);
    }
}
