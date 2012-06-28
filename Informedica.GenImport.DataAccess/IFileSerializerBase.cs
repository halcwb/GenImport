using System.Collections.Generic;
using System.IO;
using Informedica.GenImport.Library.DomainModel.Interfaces;

namespace Informedica.GenImport.DataAccess
{
    public interface IFileSerializerBase
    {
        IEnumerable<IModel> ReadLines(Stream inputStream);
    }

    public interface IFileSerializerBase<out TModel> : IFileSerializerBase
        where TModel : class, IModel
    {
        new IEnumerable<TModel> ReadLines(Stream inputStream);
    }
}
